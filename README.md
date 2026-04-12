# 💊 PharmaSI — Application de Gestion Pharmaceutique
 
> Projet réalisé dans le cadre du **BTS SIO option SLAM** — Épreuve E6  
> Développé avec **C# / Windows Forms / MySQL** sous **Visual Studio 2019**
 
---
 
## 📋 Présentation du projet
 
PharmaSI est une application de bureau développée en **C# (.NET Framework 4.7.2)** qui permet la gestion des activités d'une entreprise pharmaceutique. Elle couvre la gestion des visiteurs médicaux, des praticiens, des produits et des rapports de visite.
 
Ce projet a été réalisé en équipe dans le cadre du **BTS Services Informatiques aux Organisations, option SLAM (Solutions Logicielles et Applications Métiers)**, en réponse à un cahier des charges client simulé.
 
---
 
## 🎯 Objectifs pédagogiques (E6 BTS SIO)
 
Ce projet mobilise les compétences suivantes du référentiel BTS SIO :
 
| Compétence | Description |
|---|---|
| B1.3 | Développer une application |
| B1.4 | Concevoir et mettre en place une base de données |
| B1.6 | Organiser son travail en mode projet |
| B2.3 | Gérer les habilitations d'accès |
 
---
 
## 🧩 Fonctionnalités
 
### 🔐 Authentification
- Connexion sécurisée par identifiant et mot de passe
- Hachage du mot de passe en **SHA-256**
- Redirection automatique selon le **grade de l'utilisateur**
 
### 👤 Gestion des rôles
L'application gère **3 profils utilisateurs** distincts :
 
| Rôle | Accès |
|---|---|
| **Visiteur médical** | Fiches praticiens, fiches produits, rapport de visite |
| **Délégué régional** | Idem Visiteur + consultation des rapports |
| **Responsable secteur** | Accès complet à toutes les fonctionnalités |
 
### 🏥 Fiches Praticiens
- Recherche d'un praticien via liste déroulante
- Affichage des informations complètes : nom, adresse, type, coefficient de notoriété
- Affichage des **spécialités et diplômes** avec coefficients de prescription
 
### 💊 Fiches Produits
- Consultation des produits pharmaceutiques
- Connexion à la base de données `ppe`
 
### 📝 Rapports de visite
- Création et consultation des rapports de visite
- Sélection du praticien visité et des produits présentés
- Historique des visites consultable
 
---
 
## 🏗️ Architecture technique
 
### Stack technologique
 
```
Langage        : C# (.NET Framework 4.7.2)
Interface      : Windows Forms (WinForms)
Base de données: MySQL
Connecteur DB  : MySql.Data (NuGet)
IDE            : Visual Studio 2019
```
 
### Structure du projet
 
```
Projet - Phamarsi/
│
└── EcranConnexion/
    ├── Program.cs                  # Point d'entrée de l'application
    ├── ConnexionSql.cs             # Classe Singleton pour la connexion DB
    │
    ├── EcranConnexion.cs           # Formulaire de connexion (authentification)
    │
    ├── Accueil_Visiteur.cs         # Interface Visiteur médical
    ├── Accueil_DelegReg.cs         # Interface Délégué régional
    ├── Accueil_RespSec.cs          # Interface Responsable secteur
    │
    ├── FichePraticien.cs           # Gestion des praticiens
    ├── FicheProduit.cs             # Gestion des produits
    ├── RapportVisite.cs            # Création de rapports de visite
    ├── ConsultationRapport.cs      # Consultation des rapports
    │
    ├── Praticien.cs                # Modèle (classe métier) Praticien
    ├── Produit.cs                  # Modèle (classe métier) Produit
    └── Rapport.cs                  # Modèle (classe métier) Rapport
```
 
### Pattern de conception utilisé
 
La classe `ConnexionSql` implémente le **pattern Singleton** : une seule instance de connexion MySQL est créée et réutilisée dans toute l'application.
 
```csharp
// Exemple d'utilisation du Singleton
ConnexionSql maConnexion = ConnexionSql.getInstance("localhost", "ppe", "root", "motdepasse");
maConnexion.OpenConnexion();
```
 
---
 
## ⚙️ Installation et configuration
 
### Prérequis
 
- [Visual Studio 2019](https://visualstudio.microsoft.com/) (ou supérieur)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) installé et en cours d'exécution
- .NET Framework 4.7.2
 
### Étapes d'installation
 
**1. Cloner le repository**
```bash
git clone https://github.com/TON_USERNAME/projet-pharmasI.git
```
 
**2. Restaurer les packages NuGet**
 
Ouvrir la solution dans Visual Studio → clic droit sur la solution → *Restore NuGet Packages*
 
**3. Configurer la base de données**
 
Importer le script SQL (si fourni) dans MySQL :
```bash
mysql -u root -p < pharmasI.sql
```
 
**4. Modifier les paramètres de connexion**
 
Dans `ConnexionSql.cs`, la connexion utilise la chaîne suivante :
```csharp
string connString = $"server={provider};port=3306;database={dataBase};uid={uid};pwd={mdp}";
```
 
Adapter les valeurs dans chaque formulaire selon votre configuration MySQL locale.
 
**5. Lancer l'application**
 
Appuyer sur `F5` dans Visual Studio pour compiler et exécuter.
 
---
 
## 🗄️ Base de données
 
### Nom de la base : `ppe`
 
### Tables principales
 
| Table | Description |
|---|---|
| `employe` | Utilisateurs de l'application (login, mot de passe haché, prénom, nom) |
| `grade` | Grades/rôles des employés (Visiteur, Délégué régional, Responsable secteur) |
| `Praticien` | Médecins et professionnels de santé |
| `TypePraticien` | Types de praticiens (généraliste, spécialiste...) |
| `Specialite` | Spécialités médicales |
| `AvoirSpecialite` | Table de liaison Praticien ↔ Spécialité |
| `Produit` | Produits pharmaceutiques |
| `RapportVisite` | Rapports des visites médicales |
 
---
 
## 🔒 Sécurité
 
- Les mots de passe utilisateurs sont **hachés en SHA-256** avant toute comparaison
- Les requêtes SQL utilisent des **paramètres typés** (`@login`, `@mdp`) pour prévenir les injections SQL
- La gestion des accès est basée sur le rôle récupéré depuis la base de données
 
---
 
## 👨‍💻 Auteur
 
**Shukdeb**  
Étudiant BTS SIO option SLAM — 2ème année  
Île-de-France, France
 
---
 
## 📄 Contexte scolaire
 
> Ce projet a été développé dans le cadre du **BTS SIO (Services Informatiques aux Organisations), option SLAM**, en réponse à un projet fil rouge simulant un contexte professionnel réel. Il sera présenté lors de l'**épreuve E6** qui évalue la capacité à concevoir, développer et documenter une application informatique.
