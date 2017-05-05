
------------------------------------------------------------------------------------------------------------------------------------------------
---- Guide Utilisateur
------------------------------------------------------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------------------------------------------------------
--- Avant toute chose
------------------------------------------------------------------------------------------------------------------------------------------------

1 - Restaurez la base de donnée JobOverview.bak. 
    Pour cela, dans ssms, faîtes un click droit dans DataBase dans le menu Object Explorer et créez une nouvelle DataBase avec "New DataBase".
    Puis, faites de nouveau un click-droit sur DataBases et selectionnez "Restore DataBase". Dans la menu de destinnation, 
    choisissez la nouvelle DataBase précédemment créée. Une fois la DataBase selectionnée, depuis le menu Source de restauration, 
    choisissez l'option from device. Dans la fenêtre contextuelle "Specify BackUp", cliquez sur Add et importez le fichier 
    JobOverview.bak fourni. Cochez la CheckBox Restore à côté du nom du fichier selectionné et cliquez sur Option dans le menu "Select a page"
    et cochez l'option "Overwrite the existing DataBase". Finalement, cliquez sur OK pour finaliser la restauration de la Base de donnée. 

2 - changez la chaine de connection à votre base de données. Pour cela, allez dans l'onglet "Server Explorer" puis selectionnez votre 
    connection dans le sous-menu Data Connection. Dans la fenêtre "propriétés", copiez la "Connection string". Puis dans le 
    "Selection Explorer", cliquez sur properties et double-cliquez sur Settings.settings. Collez la chaine de connection obtenue dans 
    la case "Value".



------------------------------------------------------------------------------------------------------------------------------------------------
--- Ouverture de l'application
------------------------------------------------------------------------------------------------------------------------------------------------


3 - Lors de l'ouverture de l'application, quatre menus sont disponibles, "Gestion des version de logiciels", "Gestion des Taches", "Echanges"
    et "Fenêtres.

4 - Le menu "Fenêtre" permet d'obtenir la liste des fenêtres actives de l'application, vous permettant de passer de l'une à l'autre.



------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des version de logiciels
------------------------------------------------------------------------------------------------------------------------------------------------


5 - Le menu "Gestion des version de logiciels" se présente sous la forme de 3 éléments principaux, une liste permettant la selection 
    du logiciel et deux listes détaillants la liste des modules et des versions du logiciel selectionné. La liste des modules permet
    d'obtenir le code des différents modules du logiciel ainsi que leur libellé tandis que la liste des versions présente le détails
    des différentes versions (Numero, Millesime, Date d'ouverture, Date de sortie ...).
    La fenêtre permet également l'ajout ou la suppression d'une version grâce au bouton "Ajout Version" et "Supprimer Version".
    L'appuie sur le bonton "Ajout version" ouvre une fenêtre modale permettant de saisir le numéro de la nouvelle version, son millesime,
    sa date d'ouverture et sa date de sortie prévue. Pour finaliser l'ajout de la nouvelle version, cliquez sur OK. Dans le cas contraire,
    Cliquez sur le bouton "Annuler" pour revenir sur la fenêtre de Gestion de versions de logiciels.
    L'appuie sur le bonton "Supprimer version" permet de supprimer la ligne courrante de la liste des versions.


------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des Taches
------------------------------------------------------------------------------------------------------------------------------------------------


6 - Le menu "Gestion des Taches" présente deux sous-menu. L'un permet la gestion des taches de production et le second, la gestion des taches 
    Annexes. 
    Le sous-menu "Gestion des Taches Production" permet d'accéder à une fenêtre permettant l'affichage de la liste des tâches de production
    en fonction du Login de l'employé, du logiciel et de la version (sachant que l'on se place dans le cas du chef de projet de l'équipe
    DEV Bio humaine, qui est utilisé pour filtrer la liste des Login des employés). 
    de plus, une CheckBox permet de filtrer les tâches terminées et en cours de réalisation. Celle-ci est par défault décochée.
    La textBox sous la liste des tâches de production permet d'obtenir la description de la tâche selectionnée dans la liste.
    Le bouton "Nouvelle Tache" permet l'ajout d'une tâche pour la personne, le logiciel et la version selectionnée. Lors du click
    sur ce bouton, la fenêtre modale de création d'une nouvelle tache s'affiche, permettant de selectionner le module, l'activité et 
    le libellé dans une liste prédéfinie puis de saisir la durée prévue et restante de la tache.

7 - Le menu "Gestion des Taches Annexes" permettra d'ajouter une tâche annexe à un employé selectionné dans la liste de personnes en cliquant
    sur la CheckBox associée ou de supprimer cette tâche en la décochant. Finalement, pour confirmer la saisie, il faudra cliquez sur le
    bouton "enregistrer". Si du temps de travail à déja été saisi sur la tache à supprimer, un message d'avertissement sera afficher lors de 
    l'enregistrement.
    

------------------------------------------------------------------------------------------------------------------------------------------------
--- Echanges (Importation, exportation de fichier XML)
------------------------------------------------------------------------------------------------------------------------------------------------

8 - Le menu "Echange" présente deux sous-menu, "Importation" et "Exportation". 
    Le premier, importe une liste de tâche de production dans la base de donnée à partir d'un fichier XML.
    Pour cela, placez le fichier XML à importer qui aura pour nom "TacheProduction" dans le même repertoire que l'executable de l'application. 
    Le second, exporte une liste de tâche de production au format XML qui aura pour nom "TachesProd"dans le même repertoire.


    
 