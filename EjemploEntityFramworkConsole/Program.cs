using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntityFramworkConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usamos Using para que la conexion se cierre

            using (SampleEntityFramework db=new SampleEntityFramework()) //Crea la conexion automatica
            {

                /*
                //ADD
                //Creamos un objeto llamado oGente
                Gente oGente = new Gente();
                oGente.nombre = "Hector";
                oGente.edad = 30;
                oGente.idSexo = 2;

                db.Gente.Add(oGente); //Insert Objeto (oGente) para grabar en base datos
                db.SaveChanges(); //Para enviar la consullta a la bas de datos, es necesario

                //DELETE
                //Gente oGente = db.Gente.Where(d => d.nombre == "Ana").First(); //First para fijar la busqueda en el primer Ana, pueden haber mas Ana.
                
                Gente oGente = db.Gente.Find(10); //se puede con el where donde se puede buscar por nombre
                
                db.Gente.Remove(oGente);
                db.SaveChanges();
                
                */

                //EDIT
                //Gente oGente = db.Gente.Find(2); //se puede con el where donde se puede buscar por nombre
                Gente oGente = db.Gente.Where(d => d.nombre == "Ana").First(); //First para fijar la busqueda en el primer Ana, pueden haber mas Ana.
                oGente.edad = 45;

                db.Entry(oGente).State = System.Data.Entity.EntityState.Modified; //Para decirle a EntityFramework que se realizo una modificacion en este objeto.  Es bueno cuando se trabaja con muchos datos, concurrencia
                db.SaveChanges();

                



                

                //Para obtener los datos creamos un objeto var
                var lst = db.Gente;

                foreach (var oGente_ in lst)
                {
                    Console.WriteLine(oGente_.nombre);//Para que se detenga el programa si no hay nada
                }

            }

            Console.Read();

            //

        }
    }
}
