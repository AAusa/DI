using System.Collections;

public class Aula
{
    enum Asignaturas
    {
        Mates,
        Lengua,
        Ciencias,
        Artes
    }
    private String[] alumnado;//nombre alumnos
    private Double[,] notas;//nombre, asignatura 

    public Aula(String[] alumnos)
    {
        Random r = new Random();
        notas = new double[alumnos.Length, 4];
        alumnado = new string[alumnos.Length];
        for (int i = 0; i < alumnos.Length; i++)//Recorre alumnos
        {
            alumnado[i] = alumnos[i].ToString().Trim().ToUpper();
            for (int j = 0; j < 4; j++)//Recorre asignaturas
            {
                notas[i, j] = r.NextInt64(10);
            }
        }
    }

    public double this[String nombre, String asignatura]
    {
        get
        {
            int indiceAlumno = 0, indiceAsignatura = 0;
            if (Int32.TryParse(asignatura, out indiceAsignatura))//Si la asignatura es un numero
            {
                //Obtener indiceAlumno
                for (int i = 0; i < alumnado.Length; i++)
                {
                    if (alumnado[i].Equals(nombre.ToUpper()))
                    {
                        indiceAlumno = i;
                    }
                }
                return notas[indiceAlumno, indiceAsignatura];
            }
            else//La asignatura es un string
            {
                switch (asignatura)
                {
                    case "Mates":
                        return notas[indiceAlumno, 0];
                        break;
                    case "Lengua":
                        return notas[indiceAlumno, 1];
                        break;
                    case "Ciencias":
                        return notas[indiceAlumno, 2];
                        break;
                    case "Artes":
                        return notas[indiceAlumno, 3];
                        break;
                }
            }
            return 0;//En caso de que no se hayan dado bien los datos
        }
    }

    public double getMedia(String alumno)
    {
        double sumaNotas = 0, media = 0;
        if(alumnado.Contains(alumno.ToUpper()))
        {
            for (int i = 0; i < alumnado.Length; i++)
            {
                if (alumnado[i].Equals(alumno.ToUpper()))
                {
                    for (int j = 0; j < 3; j++)//Recorre asignaturas
                    {
                        sumaNotas += notas[i, j];
                    }
                }
            }
        }
        else
        {
            throw new ArgumentException("Alumno no encontrado");
        }
        media = sumaNotas / 4;
        return media;
    }

    public ArrayList getAprobados(ArrayList alumnos)
    {
        var aprobados = new ArrayList();
        for (int i = 0; i < alumnado.Length; i++)
        {
            if (getMedia(alumnado[i]) >= 5)
            {
                aprobados.Add(alumnado[i]);
            }
        }
        return aprobados;
    }

    public double[] getNotas(String alumno)
    {
        double[] notasAlumno = new double[3];
        if (alumnado.Contains(alumno.ToUpper()))
        {
            for (int i = 0; i < alumnado.Length; i++)
            {
                if (alumnado[i].Equals(alumno.ToUpper()))
                {
                    for (int j = 0; j < 3; j++)//Recorre asignaturas
                    {
                        notasAlumno[j] = notas[i, j];
                    }
                }
            }
        }
        else
        {
            throw new ArgumentException("Alumno no encontrado");
        }
        return notasAlumno;
    }



    public double[] getNotasAsignatura(int asignatura)//int de 0 a 3 que corresponde a una asignatura
    {
        double[] notasAsignatura = new double[alumnado.Length];
        if (asignatura < 4)
        {
            for (int i = 0; i < alumnado.Length; i++)
            {
                notasAsignatura[i] = notas[i, asignatura];
            }
        }
        else
        {
            throw new ArgumentException("Asignatura no encontrada");
        }
        return notasAsignatura;
    }
    public String getNotasMinMax(String alumno)
    {
        double min = 11, max = 0;
        if (alumnado.Contains(alumno.ToUpper()))
        {
            for (int i = 0; i < alumnado.Length; i++)
            {
                if (alumnado[i].Equals(alumno.ToUpper()))
                {
                    for (int j = 0; j < 3; j++)//Recorre asignaturas
                    {
                        if(notas[i, j] < min)
                        {
                            min = notas[i, j];
                        }
                        if (notas[i, j] > max)
                        {
                            max = notas[i, j];
                        }
                    }
                }
            }
            return "Min: " +min+"\tMax: "+max;
        }
        else
        {
            throw new ArgumentException("Alumno no encontrado");
        }
    }

    public void getAlumnado()
    {
        double min = 11, max = 0;
        
        for (int i = 0; i < alumnado.Length; i++)
        {
            Console.SetCursorPosition(5, 6+i);
            Console.WriteLine(alumnado[i]+ ": " + notas[i,0]+"\t" + notas[i, 1]+ "\t"+ notas[i, 2]);
            
        }            
    }

    //public double[,] getNotasTotal()
    //{
    //    return notas;
    //}
}