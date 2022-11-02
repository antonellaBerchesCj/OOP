namespace Learn.AggregationAndComposition
{
    /* 
     * AGGREGATION => the nested objects can independently exist in the class without being an integral part of the class. 
     * COMPOSITION => the nested objects or a singular nested object supplements the class, which makes the class 
     * inconceivable (de neconceput) without their or its existence.
     */

    public static class Composition_ex1
    {
        /* Composition in C# is a way of creating a relationship between two classes that 
         * one or greater than one nested objects are a part of the related class, and 
         * the logical existence of class becomes impossible without the nested objects.
         * 
         * For example, if we consider a class called Car, then it should have one instance of class “Engine.” 
         * Moreover, it should also have four other instances of the class “Wheel.”
         * Now, if we eliminate any of these instances, then the Car won’t function.
         */
        public static void DoWork()
        {
            PrintLogic obj = new PrintLogic();
            obj.courses = new CourseModel[9];

            for (int i = 1; i < obj.courses.Length; i++)
            {
                obj.courses[i] = new CourseModel();
                obj.courses[i].Math = i * i;
                obj.courses[i].Math = i * i * i;
            }
            
            obj.trainings = new TrainingModel[5];
            
            for (int i = 1; i < obj.trainings.Length; i++)
            {
                obj.trainings[i] = new TrainingModel();
                obj.trainings[i].equazioni = new CourseModel();
                obj.trainings[i].antologia = new CourseModel();
                obj.trainings[i].equazioni.Math = i;
                obj.trainings[i].antologia.Italian = i * 4;
                obj.trainings[i].equazioni.Math = i * 5;
                obj.trainings[i].antologia.Italian = i * i;
            }

            obj.Composition_ex1();
        }
    }

    public class CourseModel
    {
        public double Math;
        public double Italian;
    }

    public class TrainingModel
    {
        public CourseModel equazioni = null;
        public CourseModel antologia = null;
    }
}
