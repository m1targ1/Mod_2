namespace Mod_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_ClassPerson_Click(object sender, EventArgs e)
        {
            ClassPerson_1_ classPerson_1_ = new ClassPerson_1_();
            classPerson_1_.ShowDialog();
        }

        private void Button_ClassShape_Click(object sender, EventArgs e)
        {
            ClassShape_2_ classShape_2_ = new ClassShape_2_();
            classShape_2_.ShowDialog();
        }

        private void Button_Composition_Click(object sender, EventArgs e)
        {
            Compasition_3_ compasition_3_ = new Compasition_3_();
            compasition_3_.ShowDialog();
        }

        private void Button_Drawable_Click(object sender, EventArgs e)
        {
            Drawable_4_ drawable_4_ = new Drawable_4_();
            drawable_4_.ShowDialog();
        }

        private void Button_Temperature_Click(object sender, EventArgs e)
        {
            TemperatureSensor_5_ temperatureSensor_5_ = new TemperatureSensor_5_();
            temperatureSensor_5_.ShowDialog();
        }

        private void Button_Employee_Click(object sender, EventArgs e)
        {
            Employee_6_ employee_6_ = new Employee_6_();
            employee_6_.ShowDialog();
        }

        private void Button_TwoVar_Click(object sender, EventArgs e)
        {
            TwoWar_3_2_ twoWar_3_2_ = new TwoWar_3_2_();
            twoWar_3_2_.ShowDialog();
        }

        private void Button_Library_Click(object sender, EventArgs e)
        {
            Library_3_3_ library_3_3_ = new Library_3_3_();
            library_3_3_.ShowDialog();
        }
    }
}
