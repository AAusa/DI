
public class Rectangulo extends Figura {
	protected double lado1 = 0;
	protected double lado2 = 0;

	
	public Rectangulo(double lado1, double lado2) {
		this.lado1 = lado1;
		this.lado2 = lado2;
		nombreForma = "rectángulo";
	}
	
	@Override
	public double calcularArea() {
		return lado1 * lado2;
	}

	@Override
	public double calcularPerimetro() {
		return 2 * lado1 + 2 * lado2;
	}

	public double getLado1() {
		return lado1;
	}

	public void setLado1(double lado1) {
		this.lado1 = lado1;
	}

	public double getLado2() {
		return lado2;
	}

	public void setLado2(double lado2) {
		this.lado2 = lado2;
	}
	
	public double cambiarTamaño(double escala) {
		return escala * calcularArea();
	}

	@Override
	public String toString() {
		return nombreForma + " " + color + " de centro (" + centroForma.coordenadaX + "," +  centroForma.coordenadaY + ") área " + calcularArea() + " y perímetro " + calcularPerimetro();
	}
}
