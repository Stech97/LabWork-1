namespace WorkLab_1
{
    public abstract class PersonClinic
    {
        private string FIO; // ФИО 
        private int age; // Возраст
        private string sex; // Пол

        public virtual string Info()
        {
            return $"ФИО:{ FIO}, возраст:{ age}, пол:{sex}";
        }

        public PersonClinic(string FIO, int age, string sex)
        {
            this.FIO = FIO;
            this.age = age;
            this.sex = sex;
        }

        public string getFio()
        {
            return FIO;
        }

        public void SetFio(string FIO)
        {
            this.FIO = FIO;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetSex()
        {
            return sex;
        }

        public void SetNumber(string sex)
        {
            this.sex = sex;
        }
    }

    public class Doctor : PersonClinic
    {
        private int numberDoctor;// Номер доктора
        private int numberPatient;// Номер принятого пациента
        private string category;// Категория

        public Doctor(string FIO, int age, string sex, int numberDoctor, int numberPatient, string category) : base(FIO, age, sex)
        {
            this.numberDoctor = numberDoctor;
            this.numberPatient = numberPatient;
            this.category = category;
        }

        public override string Info()
        {
            return base.Info() + $" номер доктора:{numberDoctor}, номер принятого пациента:{numberPatient}, категория доктора:{category}";
        }

        public int GetNumberDoctor()
        {
            return numberDoctor;
        }

        public void SetNumberDoctor(int numberDoctor)
        {
            this.numberDoctor = numberDoctor;
        }

        public int GetNumberPatient()
        {
            return numberPatient;
        }

        public void SetNumberPatient(int numberPatient)
        {
            this.numberPatient = numberPatient;
        }

        public string GetCategory()
        {
            return category;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }
    }

    public abstract class Patient : PersonClinic
    {
        private int numberPatient;// Номер пациента
        private int numberDoctor;// Номер доктора
        private string diagnosis;// Диагноз

        public Patient(string FIO, int age, string sex, int numberDoctor, int numberPatient, string diagnosis) : base(FIO, age, sex)
        {
            this.numberPatient = numberPatient;
            this.numberDoctor = numberDoctor;
            this.diagnosis = diagnosis;
        }

        public override string Info()
        {
            return base.Info() + $" номер доктора:{numberDoctor}, номер пациента:{numberPatient}, диагноз:{diagnosis}";
        }

        public virtual string BoolToString(bool translate)
        {
            return string.Empty;
        }

        public int GetNumberPatient()
        {
            return numberPatient;
        }

        public void SetNumberPatient(int numberPatient)
        {
            this.numberPatient = numberPatient;
        }

        public int GetNumberDoctor()
        {
            return numberDoctor;
        }

        public void SetNumberDoctor(int numberDoctor)
        {
            this.numberDoctor = numberDoctor;
        }

        public string GetDiagnosis()
        {
            return diagnosis;
        }

        public void SetDiagnosis(string diagnosis)
        {
            this.diagnosis = diagnosis;
        }

    }

    public class TraumatologyPatient : Patient
    {
        private bool open; //Открытй перелом?
        private string seriousness; // Тяжесть
        private bool needOperation; //требуется операция?

        public TraumatologyPatient(string FIO, int age, string sex, int numberDoctor, int numberPatient, string diagnosis, bool open, string seriousness, bool needOperation) 
            : base(FIO, age, sex, numberDoctor, numberPatient, diagnosis)
        {
            this.open = open;
            this.seriousness = seriousness;
            this.needOperation = needOperation;
        }

        public override string Info()
        {
            return base.Info() + $" открытый перолом:{BoolToString(open)}, тяжесть:{seriousness}, требуется операция:{BoolToString(needOperation)}";
        }

        public override string BoolToString(bool translate)
        {
            return translate ? "Да" : "Нет";
        }

        public bool GetIsOpen()
        {
            return open;
        }
        public void SetIsOpen(bool open)
        {
            this.open = open;
        }

        public string GetSeriousness()
        {
            return seriousness;
        }
        public void SetSeriousness(string seriousness)
        {
            this.seriousness = seriousness;
        }

        public bool GetNeedOperation()
        {
            return needOperation;
        }
        public void GetNeedOperation(bool needOperation)
        {
            this.needOperation = needOperation;
        }

    }

    public class TherapyPatient : Patient
    {
        private string complaint; //жалобы пациента
        private bool repeat; //повторное посещение
        private bool analyzes;//наличие анализов

        public TherapyPatient(string FIO, int age, string sex, int numberDoctor, int numberPatient, string diagnosis, string complaint, bool repeat, bool analyzes) 
            : base(FIO, age, sex, numberDoctor, numberPatient, diagnosis)
        {
            this.complaint = complaint;
            this.repeat = repeat;
            this.analyzes = analyzes;
        }

        public override string Info()
        {
            return base.Info() + $" жалобы пациента:{complaint}, повторное посещение:{BoolToString(repeat)}, наличие анализов:{BoolToString(analyzes)}";
        }

        public override string BoolToString(bool translate)
        {
            return translate ? "Да" : "Нет";
        }

        public string GetComplaint()
        {
            return complaint;
        }
        public void SetComplaint(string complaint)
        {
            this.complaint = complaint;
        }

        public bool GetRepeat()
        {
            return repeat;
        }
        public void SetSeriousness(bool repeat)
        {
            this.repeat = repeat;
        }

        public bool GetAnalyzes()
        {
            return analyzes;
        }
        public void SetAnalyzes(bool analyzes)
        {
            this.analyzes = analyzes;
        }
    }

}
