namespace WIO
{
    public class WorkoutProcessor
    {
        public WorkoutSplicer WorkoutSplicer { get; set; }
        public DateProcessor DateProcessor { get; set; }
        public WeightProcessor WeightProcessor { get; set; }
        public ExerciseProcessor ExerciseProcessor { get; set; }

        public Workout ProcessWorkout(string serializedWorkout)
        {
            var workoutComponents = WorkoutSplicer.SplitWorkoutComponents(serializedWorkout);
            return new Workout
            {
                Date = DateProcessor.ProcessDate(workoutComponents.date),
                Weight = WeightProcessor.ProcessWeight(workoutComponents.weight),
                Exercises = ExerciseProcessor.ProcessExercises(workoutComponents.exercises)
            };
        }
    }
}