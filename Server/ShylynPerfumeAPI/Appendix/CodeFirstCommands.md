# Entity Framework Core Code first command
// Command Code based migration
------------------------------------------------------------------------------------------------------------------------------------

##  Add-Migration:
	Add-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Name "[MigrationName]"

##  Update-Database:
	Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI"

##  Remove the last migration if it is not applied to the database: remove the last created migration files and revert the model snapshot.
    Remove-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI"


##  Revert migration to [MigrationName]
	Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Migration "[MigrationName]"


##  Generate SQL script for migration 
    Script-Migration

### eg: To update a migration to sql script, run command:
#### //from Source to latest:
	Script-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -From "[SourceMigration]"

#### //from Source to Target:
	Script-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -From "[SourceMigration]" -To "[TargetMigration]"



------------------------------------------------------------------------------------------------------------------------------------
## Main DB:
    Add-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Project "Petronas.Data" -Name "[MigrationName]"
    (EntityFrameworkCore\Add-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Name "[MigrationName]")
	Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI"
    (EntityFrameworkCore\Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI")
	Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Args '--environment Development'
    Remove-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Project "Petronas.Data"
    (EntityFrameworkCore\Remove-Migration -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Project "Petronas.Data")

#### Roll back migration
	Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Migration "[MigrationName]"
    (EntityFrameworkCore\Update-Database -Context "DataContext" -StartupProject "ShylynPerfumeAPI" -Migration "[MigrationName]")


## Attachment DB:
	Add-Migration -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI" -Project "Petronas.Data" -Name "[MigrationName]"
	Update-Database -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI"
    (EntityFrameworkCore\Update-Database -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI")
	Update-Database -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI" -Args '--environment Development'
    Remove-Migration -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI" -Project "Petronas.Data"

#### Roll back migration
	Update-Database -Context "StorageDbContext" -StartupProject "ShylynPerfumeAPI" -Migration "[MigrationName]"


------------------------------------------------------------------------------------------------------------------------------------
### References:
#### 1. Add Migration
	PM> get-help add-migration

    NAME
        Add-Migration
    
    SYNOPSIS
        Adds a new migration.
    
    
    SYNTAX
        Add-Migration [-Name] <String> [-OutputDir <String>] [-Context <String>] [-Project <String>] [-StartupProject <String>] [-Namespace <String>] [-Args <String>] [<CommonParameters>]
    
    
    DESCRIPTION
        Adds a new migration.
    

    RELATED LINKS
        Remove-Migration
        Update-Database
        about_EntityFrameworkCore 

    REMARKS
        To see the examples, type: "get-help Add-Migration -examples".
        For more information, type: "get-help Add-Migration -detailed".
        For technical information, type: "get-help Add-Migration -full".
        For online help, type: "get-help Add-Migration -online"


#### 2. Update Database
	PM> get-help update-database

    NAME
        Update-Database
    
    SYNOPSIS
        Updates the database to a specified migration.
    
    
    SYNTAX
        Update-Database [[-Migration] <String>] [-Connection <String>] [-Context <String>] [-Project <String>] [-StartupProject <String>] [-Args <String>] [<CommonParameters>]
    
    
    DESCRIPTION
        Updates the database to a specified migration.
    

    RELATED LINKS
        Script-Migration
        about_EntityFrameworkCore 

    REMARKS
        To see the examples, type: "get-help Update-Database -examples".
        For more information, type: "get-help Update-Database -detailed".
        For technical information, type: "get-help Update-Database -full".
        For online help, type: "get-help Update-Database -online"


#### 3. Remove Migration
    PM> get-help Remove-Migration

    NAME
        Remove-Migration
    
    SYNOPSIS
        Removes the last migration.
    
    
    SYNTAX
        Remove-Migration [-Force] [-Context <String>] [-Project <String>] [-StartupProject <String>] [-Args <String>] [<CommonParameters>]
    
    
    DESCRIPTION
        Removes the last migration.
    

    RELATED LINKS
        Add-Migration
        Get-Migration
        about_EntityFrameworkCore 

    REMARKS
        To see the examples, type: "get-help Remove-Migration -examples".
        For more information, type: "get-help Remove-Migration -detailed".
        For technical information, type: "get-help Remove-Migration -full".
        For online help, type: "get-help Remove-Migration -online"


#### 4. Script Migration
    PM> get-help Script-Migration

    NAME
        Script-Migration
    
    SYNOPSIS
        Generates a SQL script from migrations.
    
    
    SYNTAX
        Script-Migration [-From] <String> [-To] <String> [-Idempotent] [-NoTransactions] [-Output <String>] [-Context <String>] [-Project <String>] [-StartupProject <String>] [-Args <String>] [<CommonParameters>]
    
        Script-Migration [[-From] <String>] [-Idempotent] [-NoTransactions] [-Output <String>] [-Context <String>] [-Project <String>] [-StartupProject <String>] [-Args <String>] [<CommonParameters>]
    
    
    DESCRIPTION
        Generates a SQL script from migrations.
    

    RELATED LINKS
        Update-Database
        Get-Migration
        about_EntityFrameworkCore 

    REMARKS
        To see the examples, type: "get-help Script-Migration -examples".
        For more information, type: "get-help Script-Migration -detailed".
        For technical information, type: "get-help Script-Migration -full".
        For online help, type: "get-help Script-Migration -online"