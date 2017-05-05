
------------------------------------------------------------------------------------------------------------------------------------------------
---- Document technique
------------------------------------------------------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------------------------------------------------------
--- Avant toute chose
------------------------------------------------------------------------------------------------------------------------------------------------


1 - Nous n'avons pas réussi à faire en sorte que la chaine de connection à la base de donnée soit modifiable sans avoir à recompiler l'application.


------------------------------------------------------------------------------------------------------------------------------------------------
--- Architecture de l'application
------------------------------------------------------------------------------------------------------------------------------------------------


2 -  Plusieurs DAl ont été créés afin de contenir des méthodes traitant d'un ensemble cohérent de concept (Une DAL pour les logiciel (DALLogiciel), 
     une pour les Tache (DALTache) et une pour l'échange de fichier (Import/Export) (DALEchange).


------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des version de logiciels
------------------------------------------------------------------------------------------------------------------------------------------------


3 - Afin de répondre à la problématique posée, une ComboBox contenant la liste des noms des différents logiciels à été créée. Celle-ci appelle une méthode 
    récupérant le résultat d'une requête SQL à la base de données.
    La DataGridView affichant la liste des modules appelle une méthode récupérant le résultat d'une requête SQL à la base de données avec en paramètre
    le nom du logiciel selectionné dans la ComboBox afin de filtrer les résultats en fonction de ce dernier.
    De même,la DataGridView affichant la liste des versions appelle une méthode semblable, permettant de filtrer cette liste en fonction du logiciel
    selectionné. 
    Les listes sont rafraichies à chaque fois qu'un logiciel différent est selectionné.

    L'ajout d'une version à été réalisé par le biais d'une fenêtre modale où l'on rentre les paramètres necessaires à l'établissement d'une nouvelle version. Puis,
    La validation sur le bouton Ok permet d'appeller une requete insert afin de creer cette nouvelle version dans la base de données.
    
    Lors de la selection d'une version dans la DataGridView, il est possible de supprimer la ligne courrante en cliquant sur le bouton "Supprimer Version" qui va
    appeler une méthode exécutant une requête SQL de delete afin de la supprimer de la base de données.

------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des Taches
------------------------------------------------------------------------------------------------------------------------------------------------


4 - Le sous-menu "Gestion des Tâches de production" présente trois ComboBox affichant chacune une liste. Ainsi, la ComboBox Login affiche les noms 
    des employés qui ont été filtrés à l'aide d'une requête link sur la liste des personnes. De même, la ComboBox présentant le numéro de version
    a été récupéré en executant une requête link sur la liste des versions. 
    La DataGridView affiche une liste de taches de production sur laquelle on a executé plusieurs filtre à l'aide de requetes link. Ainsi, le login
    de la personne, le code du logiciel et le numéro de la version ont été utilisé pour établir un premier filtrage.
    Puis, une second filtrage à été appliqué afin de ne selectionner que les taches de production et non les taches annexes. Enfin, 
    un dernier filtrage à été utilisé à l'aide d'une CheckBox qui permet d'afficher les tâches de production terminée (dont la durée restante est estimée
    à 0) si celle-ci est cochée. Par défault, elle n'est pas cochée.
    
    Cependant, pas manque de temps, l'ajout de la nouvelle tâche n'a pu être terminée, en effet, il aurait fallu lier la comboBox Activité au libellé pour 
    afficher cleui-ci directement sans avoir à le selectionner dans une ComboBox. De plus, il aurait fallu créer une méthode possédant une requête SQL permettant 
    l'insertion en masse des données dans la base et un bouton d'enregistrement dans la fenêtre mère pour valider cet ajout.
    
    Nb : ne pas oublier de créer le type Table dans la base de donnée JobOverview pour permettre de créer une table mémoire.

------------------------------------------------------------------------------------------------------------------------------------------------
--- Echanges (Importation, exportation de fichier XML)
------------------------------------------------------------------------------------------------------------------------------------------------

5 - Dans la classe "Tâche", l'idTache à été ignoré grâce à l'attribut [XmlIgnore] tandis que toutes les autres propriétés ont étés décorés d'un attribut [XmlAttribute("Nom")]
    Ainsi, l'appel des méthodes d'importation et d'exportation à été rendu possible.
   
    
 