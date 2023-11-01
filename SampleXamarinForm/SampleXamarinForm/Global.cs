using System;
namespace SampleXamarinForm
{
	public class Global
	{
		public Global()
		{
		}

        private static Global _instance;
        public static Global Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance;
            }
        }
        public String myData { get; set; }
        
    }
}

