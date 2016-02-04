Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace MonitoringDatabase
    Public Class DBModel
        Inherits DbContext

        ' Your context has been configured to use a 'DBModel' connection string from your application's 
        ' configuration file (App.config or Web.config). By default, this connection string targets the 
        ' 'DBInstallerCA.DBModel' database on your LocalDb instance. 
        ' 
        ' If you wish to target a different database and/or database provider, modify the 'DBModel' 
        ' connection string in the application configuration file.

        Public Sub New()
            MyBase.New("name=Monitoring")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()

            'AgentSystem Table
            modelBuilder.Entity(Of AgentSystem).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentDomain).HasMaxLength(50)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentIP).HasMaxLength(15)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentOSName).HasMaxLength(100)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentOSBuild).HasMaxLength(25)
            modelBuilder.Entity(Of AgentSystem).Property(Function(t) t.AgentOSArchitecture).HasMaxLength(25)

            'AgentProcessor Table
            modelBuilder.Entity(Of AgentProcessor).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentProcessor).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentProcessor).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentProcessor).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentMemory Table
            modelBuilder.Entity(Of AgentMemory).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentMemory).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentMemory).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentMemory).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentPageFile Table
            modelBuilder.Entity(Of AgentPageFile).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentPageFile).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentPageFile).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentPageFile).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentLocalDisk Table
            modelBuilder.Entity(Of AgentLocalDisk).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentLocalDisk).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentLocalDisk).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentLocalDisk).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentServices Table
            modelBuilder.Entity(Of AgentService).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentService).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentService).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentService).Property(Function(t) t.AgentProperty).HasMaxLength(100)

            'Archive Tables

            'AgentProcessor Table
            modelBuilder.Entity(Of AgentProcessorArchive).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentProcessorArchive).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentProcessorArchive).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentProcessorArchive).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentMemory Table
            modelBuilder.Entity(Of AgentMemoryArchive).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentMemoryArchive).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentMemoryArchive).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentMemoryArchive).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentPageFile Table
            modelBuilder.Entity(Of AgentPageFileArchive).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentPageFileArchive).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentPageFileArchive).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentPageFileArchive).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentLocalDisk Table
            modelBuilder.Entity(Of AgentLocalDiskArchive).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentLocalDiskArchive).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentLocalDiskArchive).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentLocalDiskArchive).Property(Function(t) t.AgentProperty).HasMaxLength(50)

            'AgentServices Table
            modelBuilder.Entity(Of AgentServiceArchive).HasKey(Function(t) t.AgentID)
            modelBuilder.Entity(Of AgentServiceArchive).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentServiceArchive).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentServiceArchive).Property(Function(t) t.AgentProperty).HasMaxLength(100)

            'AgentEvents Table
            modelBuilder.Entity(Of AgentEvents).HasKey(Function(t) t.EventID)
            modelBuilder.Entity(Of AgentEvents).Property(Function(t) t.EventHostname).HasMaxLength(50)
            modelBuilder.Entity(Of AgentEvents).Property(Function(t) t.EventMessage).HasMaxLength(5000)
            modelBuilder.Entity(Of AgentEvents).Property(Function(t) t.EventClass).HasMaxLength(100)
            modelBuilder.Entity(Of AgentEvents).Property(Function(t) t.EventProperty).HasMaxLength(100)
            modelBuilder.Entity(Of AgentEvents).Property(Function(t) t.EventComparison).HasMaxLength(2)

            'ThresholdTables

            'AgentThresholds
            modelBuilder.Entity(Of AgentThresholds).HasKey(Function(t) t.ThresholdID)
            modelBuilder.Entity(Of AgentThresholds).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of AgentThresholds).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of AgentThresholds).Property(Function(t) t.AgentProperty).HasMaxLength(50)
            modelBuilder.Entity(Of AgentThresholds).Property(Function(t) t.Comparison).HasMaxLength(2)

            'GroupThresholds
            modelBuilder.Entity(Of GlobalThresholds).HasKey(Function(t) t.ThresholdID)
            modelBuilder.Entity(Of GlobalThresholds).Property(Function(t) t.AgentClass).HasMaxLength(25)
            modelBuilder.Entity(Of GlobalThresholds).Property(Function(t) t.AgentProperty).HasMaxLength(50)
            modelBuilder.Entity(Of GlobalThresholds).Property(Function(t) t.Comparison).HasMaxLength(2)

            'Users
            modelBuilder.Entity(Of Users).HasKey(Function(t) t.UserID)
            modelBuilder.Entity(Of Users).Property(Function(t) t.UserName).HasMaxLength(50)
            modelBuilder.Entity(Of Users).Property(Function(t) t.FirstName).HasMaxLength(50)
            modelBuilder.Entity(Of Users).Property(Function(t) t.LastName).HasMaxLength(50)
            modelBuilder.Entity(Of Users).Property(Function(t) t.Password).HasMaxLength(150)
            modelBuilder.Entity(Of Users).Property(Function(t) t.EmailAddress).HasMaxLength(100)
            modelBuilder.Entity(Of Users).Property(Function(t) t.UserRole).HasMaxLength(50)

            'Subscriptions
            modelBuilder.Entity(Of Subscriptions).HasKey(Function(t) t.SubscriptionID)
            modelBuilder.Entity(Of Subscriptions).Property(Function(t) t.AgentName).HasMaxLength(50)
            modelBuilder.Entity(Of Subscriptions).Property(Function(t) t.UserName).HasMaxLength(50)

            'Configuration
            modelBuilder.Entity(Of ServerConfiguration).HasKey(Function(t) t.ConfigID)
            modelBuilder.Entity(Of ServerConfiguration).Property(Function(t) t.Name).HasMaxLength(50)
            modelBuilder.Entity(Of ServerConfiguration).Property(Function(t) t.Value).HasMaxLength(50)

        End Sub



        ' Add a DbSet for each entity type that you want to include in your model. For more information 
        ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.

        Public Overridable Property AgentEvents As DbSet(Of AgentEvents)
        Public Overridable Property AgentLocalDisk As DbSet(Of AgentLocalDisk)
        Public Overridable Property AgentLocalDiskArchive As DbSet(Of AgentLocalDiskArchive)
        Public Overridable Property AgentMemory As DbSet(Of AgentMemory)
        Public Overridable Property AgentMemoryArchive As DbSet(Of AgentMemoryArchive)
        Public Overridable Property AgentPageFile As DbSet(Of AgentPageFile)
        Public Overridable Property AgentPageFileArchive As DbSet(Of AgentPageFileArchive)
        Public Overridable Property AgentProcessor As DbSet(Of AgentProcessor)
        Public Overridable Property AgentProcessorArchive As DbSet(Of AgentProcessorArchive)
        Public Overridable Property AgentSystem As DbSet(Of AgentSystem)
        Public Overridable Property AgentService As DbSet(Of AgentService)
        Public Overridable Property AgentServiceArchive As DbSet(Of AgentServiceArchive)
        Public Overridable Property AgentThresholds As DbSet(Of AgentThresholds)
        Public Overridable Property ServerConfiguration As DbSet(Of ServerConfiguration)
        Public Overridable Property GlobalThresholds As DbSet(Of GlobalThresholds)
        Public Overridable Property Subscriptions As DbSet(Of Subscriptions)
        Public Overridable Property Users As DbSet(Of Users)

    End Class
End Namespace




