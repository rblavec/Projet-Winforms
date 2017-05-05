
------------------------------------------------------------------------------------------------------------------------------------------------
---- Guide Utilisateur
------------------------------------------------------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------------------------------------------------------
--- Avant toute chose
------------------------------------------------------------------------------------------------------------------------------------------------

1 - Restaurez la base de donn�e JobOverview.bak. 
    Pour cela, dans ssms, fa�tes un click droit dans DataBase dans le menu Object Explorer et cr�ez une nouvelle DataBase avec "New DataBase".
    Puis, faites de nouveau un click-droit sur DataBases et selectionnez "Restore DataBase". Dans la menu de destinnation, 
    choisissez la nouvelle DataBase pr�c�demment cr��e. Une fois la DataBase selectionn�e, depuis le menu Source de restauration, 
    choisissez l'option from device. Dans la fen�tre contextuelle "Specify BackUp", cliquez sur Add et importez le fichier 
    JobOverview.bak fourni. Cochez la CheckBox Restore � c�t� du nom du fichier selectionn� et cliquez sur Option dans le menu "Select a page"
    et cochez l'option "Overwrite the existing DataBase". Finalement, cliquez sur OK pour finaliser la restauration de la Base de donn�e. 

2 - changez la chaine de connection � votre base de donn�es. Pour cela, allez dans l'onglet "Server Explorer" puis selectionnez votre 
    connection dans le sous-menu Data Connection. Dans la fen�tre "propri�t�s", copiez la "Connection string". Puis dans le 
    "Selection Explorer", cliquez sur properties et double-cliquez sur Settings.settings. Collez la chaine de connection obtenue dans 
    la case "Value".



------------------------------------------------------------------------------------------------------------------------------------------------
--- Ouverture de l'application
------------------------------------------------------------------------------------------------------------------------------------------------


3 - Lors de l'ouverture de l'application, quatre menus sont disponibles, "Gestion des version de logiciels", "Gestion des Taches", "Echanges"
    et "Fen�tres.

4 - Le menu "Fen�tre" permet d'obtenir la liste des fen�tres actives de l'application, vous permettant de passer de l'une � l'autre.



------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des version de logiciels
------------------------------------------------------------------------------------------------------------------------------------------------


5 - Le menu "Gestion des version de logiciels" se pr�sente sous la forme de 3 �l�ments principaux, une liste permettant la selection 
    du logiciel et deux listes d�taillants la liste des modules et des versions du logiciel selectionn�. La liste des modules permet
    d'obtenir le code des diff�rents modules du logiciel ainsi que leur libell� tandis que la liste des versions pr�sente le d�tails
    des diff�rentes versions (Numero, Millesime, Date d'ouverture, Date de sortie ...).
    La fen�tre permet �galement l'ajout ou la suppression d'une version gr�ce au bouton "Ajout Version" et "Supprimer Version".
    L'appuie sur le bonton "Ajout version" ouvre une fen�tre modale permettant de saisir le num�ro de la nouvelle version, son millesime,
    sa date d'ouverture et sa date de sortie pr�vue. Pour finaliser l'ajout de la nouvelle version, cliquez sur OK. Dans le cas contraire,
    Cliquez sur le bouton "Annuler" pour revenir sur la fen�tre de Gestion de versions de logiciels.
    L'appuie sur le bonton "Supprimer version" permet de supprimer la ligne courrante de la liste des versions.


------------------------------------------------------------------------------------------------------------------------------------------------
--- Gestion des Taches
------------------------------------------------------------------------------------------------------------------------------------------------


6 - Le menu "Gestion des Taches" pr�sente deux sous-menu. L'un permet la gestion des taches de production et le second, la gestion des taches 
    Annexes. 
    Le sous-menu "Gestion des Taches Production" permet d'acc�der � une fen�tre permettant l'affichage de la liste des t�ches de production
    en fonction du Login de l'employ�, du logiciel et de la version (sachant que l'on se place dans le cas du chef de projet de l'�quipe
    DEV Bio humaine, qui est utilis� pour filtrer la liste des Login des employ�s). 
    de plus, une CheckBox permet de filtrer les t�ches termin�es et en cours de r�alisation. Celle-ci est par d�fault d�coch�e.
    La textBox sous la liste des t�ches de production permet d'obtenir la description de la t�che selectionn�e dans la liste.
    Le bouton "Nouvelle Tache" permet l'ajout d'une t�che pour la personne, le logiciel et la version selectionn�e. Lors du click
    sur ce bouton, la fen�tre modale de cr�ation d'une nouvelle tache s'affiche, permettant de selectionner le module, l'activit� et 
    le libell� dans une liste pr�d�finie puis de saisir la dur�e pr�vue et restante de la tache.

7 - Le menu "Gestion des Taches Annexes" permettra d'ajouter une t�che annexe � un employ� selectionn� dans la liste de personnes en cliquant
    sur la CheckBox associ�e ou de supprimer cette t�che en la d�cochant. Finalement, pour confirmer la saisie, il faudra cliquez sur le
    bouton "enregistrer". Si du temps de travail � d�ja �t� saisi sur la tache � supprimer, un message d'avertissement sera afficher lors de 
    l'enregistrement.
    

------------------------------------------------------------------------------------------------------------------------------------------------
--- Echanges (Importation, exportation de fichier XML)
------------------------------------------------------------------------------------------------------------------------------------------------

8 - Le menu "Echange" pr�sente deux sous-menu, "Importation" et "Exportation". 
    Le premier, importe une liste de t�che de production dans la base de donn�e � partir d'un fichier XML.
    Pour cela, placez le fichier XML � importer qui aura pour nom "TacheProduction" dans le m�me repertoire que l'executable de l'application. 
    Le second, exporte une liste de t�che de production au format XML qui aura pour nom "TachesProd"dans le m�me repertoire.


    
 