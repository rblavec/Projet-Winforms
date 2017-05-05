
------------------------------------------------------------------------------------------------------------------------------------------------
---- Document technique
------------------------------------------------------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------------------------------------------------------
--- Avant toute chose
------------------------------------------------------------------------------------------------------------------------------------------------


1 - Nous n'avons pas r�ussi � faire en sorte que la chaine de connection � la base de donn�e soit modifiable sans avoir � recompiler l'application.


------------------------------------------------------------------------------------------------------------------------------------------------
--- Architecture de l'application
------------------------------------------------------------------------------------------------------------------------------------------------


2 -  Plusieurs DAl ont �t� cr��s afin de contenir des m�thodes traitant d'un ensemble coh�rent de concept (Une DAL pour les logiciel (DALLogiciel), 
     une pour les Tache (DALTache) et une pour l'�change de fichier (Import/Export) (DALEchange).


------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des version de logiciels
------------------------------------------------------------------------------------------------------------------------------------------------


3 - Afin de r�pondre � la probl�matique pos�e, une ComboBox contenant la liste des noms des diff�rents logiciels � �t� cr��e. Celle-ci appelle une m�thode 
    r�cup�rant le r�sultat d'une requ�te SQL � la base de donn�es.
    La DataGridView affichant la liste des modules appelle une m�thode r�cup�rant le r�sultat d'une requ�te SQL � la base de donn�es avec en param�tre
    le nom du logiciel selectionn� dans la ComboBox afin de filtrer les r�sultats en fonction de ce dernier.
    De m�me,la DataGridView affichant la liste des versions appelle une m�thode semblable, permettant de filtrer cette liste en fonction du logiciel
    selectionn�. 
    Les listes sont rafraichies � chaque fois qu'un logiciel diff�rent est selectionn�.

    L'ajout d'une version � �t� r�alis� par le biais d'une fen�tre modale o� l'on rentre les param�tres necessaires � l'�tablissement d'une nouvelle version. Puis,
    La validation sur le bouton Ok permet d'appeller une requete insert afin de creer cette nouvelle version dans la base de donn�es.
    
    Lors de la selection d'une version dans la DataGridView, il est possible de supprimer la ligne courrante en cliquant sur le bouton "Supprimer Version" qui va
    appeler une m�thode ex�cutant une requ�te SQL de delete afin de la supprimer de la base de donn�es.

------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des Taches
------------------------------------------------------------------------------------------------------------------------------------------------


4 - Le sous-menu "Gestion des T�ches de production" pr�sente trois ComboBox affichant chacune une liste. Ainsi, la ComboBox Login affiche les noms 
    des employ�s qui ont �t� filtr�s � l'aide d'une requ�te link sur la liste des personnes. De m�me, la ComboBox pr�sentant le num�ro de version
    a �t� r�cup�r� en executant une requ�te link sur la liste des versions. 
    La DataGridView affiche une liste de taches de production sur laquelle on a execut� plusieurs filtre � l'aide de requetes link. Ainsi, le login
    de la personne, le code du logiciel et le num�ro de la version ont �t� utilis� pour �tablir un premier filtrage.
    Puis, une second filtrage � �t� appliqu� afin de ne selectionner que les taches de production et non les taches annexes. Enfin, 
    un dernier filtrage � �t� utilis� � l'aide d'une CheckBox qui permet d'afficher les t�ches de production termin�e (dont la dur�e restante est estim�e
    � 0) si celle-ci est coch�e. Par d�fault, elle n'est pas coch�e.
    
    Cependant, pas manque de temps, l'ajout de la nouvelle t�che n'a pu �tre termin�e, en effet, il aurait fallu lier la comboBox Activit� au libell� pour 
    afficher cleui-ci directement sans avoir � le selectionner dans une ComboBox. De plus, il aurait fallu cr�er une m�thode poss�dant une requ�te SQL permettant 
    l'insertion en masse des donn�es dans la base et un bouton d'enregistrement dans la fen�tre m�re pour valider cet ajout.
    
    Nb : ne pas oublier de cr�er le type Table dans la base de donn�e JobOverview pour permettre de cr�er une table m�moire.

------------------------------------------------------------------------------------------------------------------------------------------------
--- Echanges (Importation, exportation de fichier XML)
------------------------------------------------------------------------------------------------------------------------------------------------

5 - Dans la classe "T�che", l'idTache � �t� ignor� gr�ce � l'attribut [XmlIgnore] tandis que toutes les autres propri�t�s ont �t�s d�cor�s d'un attribut [XmlAttribute("Nom")]
    Ainsi, l'appel des m�thodes d'importation et d'exportation � �t� rendu possible.
   
    
 