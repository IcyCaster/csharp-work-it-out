using System;
using System.Collections.Generic;
using UnitsNet.Units;
using Xunit;

namespace WIO.Tests
{
    public class PersonalAcceptanceTests
    {
        [Fact]
        public void SingleWorkout()
        {
            const string serialWorkout = "10/11\n" +
                                   "100.0kg\n" +
                                   "Squat 20,20";
            var workoutProcessor = new WorkoutProcessor();
            var workout = workoutProcessor.ProcessWorkout(serialWorkout);

            var expectedWorkout = new Workout
            {
                Date = new DateTime(),
                Weight = new Weight
                {
                    MassUnit = MassUnit.Kilogram,
                    Mass = 100
                },
                Exercises = new List<Exercise>
                {
                    new Exercise
                    {
                        Name = "Squat",
                        Sets = new List<Set>
                        {
                            new Set
                            {
                                Repetitions = 20,
                                Weight = 20
                            }
                        }
                    }
                }
            };

            Assert.Equal(expectedWorkout, workout);
        }
    }

}
