public  class Empleado : Persona
{
    private double salario;
    private int irpf;
    private String nTfno;

    public Empleado(int edad, String nombre, String apellidos, String dni, double salario, int irpf, String nTfno)
    :base(edad, nombre, apellidos, dni)
    {
        this.salario = salario;
        this.irpf = irpf;
        this.nTfno = nTfno;
    }

    public Empleado() : this(0, "", "", "", 0, 0, "")
    {
    }


    public double Salario
    {
        set
        {
            if (value < 600) irpf = 7;
            else if (value > 600 && value < 3000) irpf = 15;
            else irpf = 20;
        }
        get
        {
            return salario;
        }
    }

    public int Irpf
    {
        get
        {
            return irpf;
        }
    }

    public String NTfno
    {
        set
        {
            nTfno = value;

        }
        get
        {
            return "+34" + nTfno;
        }
    }

    public override void mostrar()
    {
        base.mostrar();
        System.Console.WriteLine("Salario: " + salario + ". Irpf: " + irpf + ". nTfno: " + nTfno);
    }

    public String mostrar(int dato)
    {
        String[] opciones = {Nombre, Apellidos, Edad+"", Dni, salario+"", irpf+"", nTfno};
        return opciones[dato];
    }

    public override double hacienda()
    {
        return irpf * salario / 100;
    }
}