using static Learn.AggregationAndComposition.Composition_ex2;

namespace Learn.AggregationAndComposition
{
    public class PrintLogic
    {
        public CourseModel[] courses;
        public TrainingModel[] trainings;
        public PrintLogic()
        {
            courses = null;
            trainings = null;
        }
        public void Composition_ex1()
        {
            Console.WriteLine(" Courses Data is represented below:");
            for (int i = 1; i < courses.Length; i++)
            {
                Console.WriteLine("\n Math = {0}, Italian = {1}", courses[i].Math, courses[i].Italian);
            }

            Console.WriteLine("\n Trainings Data is represented below:");

            for (int i = 1; i < trainings.Length; i++)
            {
                Console.WriteLine("\n course1.Math = {0}, course1.Italian = {1}", 
                    trainings[i].equazioni.Math, trainings[i].equazioni.Italian);
                Console.WriteLine("\n course2.Math = {0}, course2.Italian = {1}", 
                    trainings[i].antologia.Math, trainings[i].antologia.Italian);

            }
        }
        public void Composition_ex2()
        {
            Input client = new Input();
            DataScience data_analysis = new DataScience();
            Console.WriteLine("INPUT: \n Best Course to Upgrade Career:");
            client.InputCode(data_analysis);
            Course vr = new Course();
            Course career1 = new Course();
            career1.Add(new DataScience());
            career1.Add(new DataScience());
            Course career2 = new Course();
            career2.Add(new DataScience());
            vr.Add(career1);
            vr.Add(career2);
            Console.WriteLine("\nINPUT: \n Trendy Dream Career Right Now:");
            client.InputCode(vr);
            Console.Write("\nINPUT: Lets Upgrade and start your dream career jouney: \n");
            client.InputCode2(vr, data_analysis);
        }
    }
}
