class Teacher 
{
    string name;
    string gender;
    double experience;
    DateTime birthDate;
    public string Name ()
    {
        get
        {
            return value;
        }
       
        set 
        {
            strinh value;
            if(value.Length()>2 && value != null)
                name = value;
        }

    }

    public string gender ()
    {
        get
        {
            return value;
        }
        set
        {
            string value;
            if (value == "male"|| value == "female")
            {
                gender = value;
            }
            else
            {
                gender = "male";
            }
        }

       public double Experience()
        }
            get;
            set;     
        }
    }

}