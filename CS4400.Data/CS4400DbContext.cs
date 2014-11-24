using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4400.Data
{
    //public class ExerciseContextDbInitializer : CreateDatabaseIfNotExists<ExerciseDbContext>
    ////public class ExerciseContextDbInitializer : DropCreateDatabaseIfModelChanges<ExerciseDbContext>
    //{
    //    protected override void Seed(ExerciseDbContext context)
    //    {
    //        Seeder.Seed(context);
    //        base.Seed(context);
    //    }
    //}

    //public partial class ExerciseDbContext : DbContext
    //{
    //    public ExerciseDbContext()
    //        : base("Name=ExercisePlanner")//this is the connection string name
    //    {
    //        Database.SetInitializer<ExerciseDbContext>(new ExerciseContextDbInitializer());

    //        try
    //        {
    //            base.Database.Initialize(true);
    //        }
    //        catch (DbEntityValidationException e)
    //        {
    //            var validationErrors = e.EntityValidationErrors.ToList();
    //            var exceptionStr = e.ToString();
    //        }
    //        catch (Exception e)
    //        {
    //            var exceptionStr = e.ToString();
    //        }
    //    }

    //    public DbSet<Client> Clients { get; set; }
    //    public DbSet<EmailRecord> EmailRecords { get; set; }
    //    public DbSet<Trainer> Trainers { get; set; }
    //    public DbSet<TrainerAccount> TrainerAccounts { get; set; }
    //    public DbSet<Exercise> Exercises { get; set; }
    //    public DbSet<ExerciseTarget> ExerciseTargets { get; set; }
    //    public DbSet<ExerciseTargetAchievedInstance> ExerciseTargetAchievedInstances { get; set; }
    //    public DbSet<ExerciseInstance> ExerciseInstances { get; set; }
    //    public DbSet<ExercisePlan> ExercisePlans { get; set; }
    //    public DbSet<ExercisePlanWorkout> ExercisePlanWorkouts { get; set; }
    //    public DbSet<ExercisePlanWorkoutExercise> ExercisePlanWorkoutExercises { get; set; }
    //    public DbSet<Workout> Workouts { get; set; }
    //    public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
    //    public DbSet<WorkoutInstance> WorkoutInstances { get; set; }

    //    public DbSet<Diet> Diets { get; set; }
    //    public DbSet<Meal> Meals { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

    //        modelBuilder.Configurations.Add(new ClientConfig());
    //        modelBuilder.Configurations.Add(new ClientExerciseConfig());
    //        modelBuilder.Configurations.Add(new TrainerConfig());
    //        modelBuilder.Configurations.Add(new ExerciseConfig());
    //        modelBuilder.Configurations.Add(new ExerciseInstanceConfig());
    //        modelBuilder.Configurations.Add(new ExercisePlanConfig());
    //        modelBuilder.Configurations.Add(new ExercisePlanWorkoutConfig());
    //        modelBuilder.Configurations.Add(new ExercisePlanWorkoutExerciseConfig());
    //        modelBuilder.Configurations.Add(new ExercisePlanInstanceConfig());
    //        modelBuilder.Configurations.Add(new WorkoutConfig());
    //        modelBuilder.Configurations.Add(new WorkoutInstanceConfig());

    //        modelBuilder.Configurations.Add(new DietConfig());
    //        modelBuilder.Configurations.Add(new DietMealConfig());

    //        base.OnModelCreating(modelBuilder);
    //    }

    //    public class DietConfig : EntityTypeConfiguration<Diet>
    //    {
    //        public DietConfig()
    //        {
    //            this.HasMany(a => a.Meals).WithOptional();
    //        }
    //    }

    //    public class DietMealConfig : EntityTypeConfiguration<DietMeal>
    //    {
    //        public DietMealConfig()
    //        {
    //            this.HasRequired(a => a.Meal).WithMany().WillCascadeOnDelete(false);
    //        }
    //    }

    //    public class MealConfig : EntityTypeConfiguration<Meal>
    //    {
    //        public MealConfig()
    //        {

    //        }
    //    }

    //    public class ClientConfig : EntityTypeConfiguration<Client>
    //    {
    //        public ClientConfig()
    //        {
    //            this.HasMany(a => a.ExercisePlanInstances).WithOptional();
    //            this.HasMany(a => a.Exercises).WithOptional();
    //        }
    //    }

    //    public class ClientExerciseConfig : EntityTypeConfiguration<ClientExercise>
    //    {
    //        public ClientExerciseConfig()
    //        {
    //            this.HasMany(a => a.Targets).WithOptional();
    //        }
    //    }

    //    public class TrainerConfig : EntityTypeConfiguration<Trainer>
    //    {
    //        public TrainerConfig()
    //        {
    //            this.HasMany(a => a.Clients); //.WithOptional().HasForeignKey(a => a.TrainerId);
    //            this.HasMany(a => a.ExercisePlans); //.WithOptional().HasForeignKey(a => a.TrainerId);
    //            this.HasMany(a => a.DietPlans);
    //        }
    //    }

    //    public class ExerciseConfig : EntityTypeConfiguration<Exercise>
    //    {
    //        public ExerciseConfig()
    //        {
    //            this.HasMany(a => a.Targets).WithOptional();
    //        }
    //    }

    //    public class ExerciseInstanceConfig : EntityTypeConfiguration<ExerciseInstance>
    //    {
    //        public ExerciseInstanceConfig()
    //        {
    //            this.HasRequired(a => a.Exercise).WithMany().WillCascadeOnDelete(false);
    //            this.HasMany(a => a.Targets).WithOptional();
    //            this.HasMany(a => a.AchievedTargets).WithOptional();
    //        }
    //    }

    //    public class ExercisePlanConfig : EntityTypeConfiguration<ExercisePlan>
    //    {
    //        public ExercisePlanConfig()
    //        {
    //            this.HasMany(a => a.Workouts).WithOptional();
    //        }
    //    }

    //    public class ExercisePlanWorkoutConfig : EntityTypeConfiguration<ExercisePlanWorkout>
    //    {
    //        public ExercisePlanWorkoutConfig()
    //        {
    //            this.HasRequired(a => a.Workout).WithMany();
    //            this.HasMany(a => a.Exercises).WithOptional();
    //        }
    //    }

    //    public class ExercisePlanWorkoutExerciseConfig : EntityTypeConfiguration<ExercisePlanWorkoutExercise>
    //    {
    //        public ExercisePlanWorkoutExerciseConfig()
    //        {
    //            this.HasRequired(a => a.Exercise).WithMany();
    //        }
    //    }

    //    public class ExercisePlanInstanceConfig : EntityTypeConfiguration<ExercisePlanInstance>
    //    {
    //        public ExercisePlanInstanceConfig()
    //        {
    //            this.HasMany(a => a.Workouts).WithOptional();
    //        }
    //    }

    //    public class WorkoutConfig : EntityTypeConfiguration<Workout>
    //    {
    //        public WorkoutConfig()
    //        {
    //            this.HasMany(a => a.Exercises).WithMany();
    //        }
    //    }

    //    public class WorkoutGroupConfig : EntityTypeConfiguration<WorkoutGroup>
    //    {
    //        public WorkoutGroupConfig()
    //        {
    //            this.HasMany(a => a.Workouts).WithMany();
    //        }
    //    }

    //    public class WorkoutInstanceConfig : EntityTypeConfiguration<WorkoutInstance>
    //    {
    //        public WorkoutInstanceConfig()
    //        {
    //            this.HasRequired(a => a.Workout).WithMany().WillCascadeOnDelete(false);
    //            this.HasMany(a => a.Exercises).WithOptional();
    //        }
    //    }
    //}
}