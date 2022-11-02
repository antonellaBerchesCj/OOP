namespace Learn.AggregationAndComposition
{
    public class Composition_ex2
    {
        public abstract class Training
        {
            public Training() { }

            public abstract string Project();

            public virtual void Add(Training training)
            {
                throw new NotImplementedException();
            }

            public virtual void Remove(Training training)
            {
                throw new NotImplementedException();
            }

            public virtual bool IsCourse()
            {
                return true;
            }
        }
        public class DataScience : Training
        {
            public override string Project()
            {
                return "DataScience";
            }
            public override bool IsCourse()
            {
                return false;
            }
        }
        public class Course : Training
        {
            protected List<Training> _children = new List<Training>();
            public override void Add(Training training)
            {
                this._children.Add(training);
            }
            public override void Remove(Training training)
            {
                this._children.Remove(training);
            }
            public override string Project()
            {
                int m = 1;
                string result = "Dream Career(";
                foreach (Training training in this._children)
                {
                    result += training.Project();
                    if (m != this._children.Count + 2)
                    {
                        result += "-";
                    }
                    m--;
                }
                return result + ")";
            }
        }
        public class Input
        {
            public void InputCode(Training data_analysis)
            {
                Console.WriteLine($"OUTPUT: \n {data_analysis.Project()}\n");
            }
            public void InputCode2(Training training1, Training training2)
            {
                if (training1.IsCourse())
                {
                    training1.Add(training2);
                }
                Console.WriteLine($"OUTPUT: \n {training1.Project()}");
            }
        }
    }
}
