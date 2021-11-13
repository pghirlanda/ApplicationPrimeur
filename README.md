# Présentation du sujet

Bingo ! Le Primeur de la Côte, un primeur qui fait les meilleurs fruits et légumes à Biarritz et sur le BAB, situé à Beaurivage, a publié un appel d'offre pour répondre à son besoin de digitaliser son commerce: un logiciel de caisse sur Windows ! Voici l'annonce d'Antoine, gérant du primeur:  
L'entreprise du primeur de la côte aimerait s'équiper de logiciel de caisses pour générer les tickets de caisse des client lors de l'encaissement. Le logiciel doit fonctionner sur windows. Il doit permettre de faire évoluer les prix au kilo des produits en fonction des saisons et des approvisionnements. Le logiciel doit être accompagné d'un manuel d'utilisation au format PDF et du diagramme des classes au cas où l'entreprise choisie ne puisse plus assurer la maintenance du logiciel.

# Scénario d'utilisation
Lors d'un passage en caisse, l'utilisateur (opérateur de caisse) précise sur l'application qu'il fait un nouveau panier. Il pèse le produit manuellement, il indique le produit et saisit le poids sur l'application, et valide pour ajouter le produit et son coût au panier. Il rajoute d'autres produits et leurs quantités. Il peut voir à tout moment le montant du panier. A chaque nouveau produit et quantité ajoutés au panier, une ligne est écrite dans un fichier texte ticket.txt. Quand le panier est terminé, l'utilisateur peut afficher le ticket de caisse en appuyant sur un bouton de l'application, ou, si c'est impossible, en allant chercher manuellement le fichier dans le disque dur. Le but étant de pouvoir l'imprimer.  
Tous les matins avant d'ouvrir la boutique, Antoine doit charger le fichier base de données de fruits et légumes grâce à la fenêtre "Ouvrir" du programme. Attention: l'opérateur de caisse ne peut pas ajouter des produits qui ne sont pas dans le fichier de données fruits et légumes. 

# Base de données des produits
Tous les produits disponibles et leurs prix au kilo sont disponibles sur un fichier .csv que le primeur souhaite modifier sur excel quand il le souhaite. Dans ce fichier, le séparateur décimal pour le prix est la virgule.  Le format de ce fichier est le suivant :  

Nomduproduit;PrixAuKilo  
Nomduproduit;PrixAuKilo  
Nomduproduit;PrixAuKilo  
...  
Tomates;3,90
