public  class EmpleadoEspecial : Empleado, IPastaGansa
{

    private double PastaGanada;

    public EmpleadoEspecial(int edad, String nombre, String apellidos, String dni, double salario, int irpf, String nTfno)
    : base(edad, nombre, apellidos, dni, salario, irpf, nTfno)
    {
    }

    public double ganarPasta(double beneficiosTotales)
    {
        PastaGanada = 0.5 / beneficiosTotales;
        return PastaGanada;
    }

    public override double hacienda()
    {
        return base.hacienda() + base.Salario * 0.5;
    }
}