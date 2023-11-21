using ArrayObjeto.Entidades;
using System.Runtime.CompilerServices;

namespace ArrayObjeto.Datos
{
    public class RepositorioDeObjetos
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Objetos.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Objetos.bak";
        private List<Objeto> listaObjetos;

        public RepositorioDeObjetos()
        {
            listaObjetos = new List<Objeto>();
            LeerDatos();
        }
        public bool Existe(Objeto objeto)
        {
            listaObjetos.Clear();
            LeerDatos();
            foreach (var itemObjeto in listaObjetos)
            {
                if (itemObjeto.GetLado() == objeto.GetLado())
                {
                    return true;
                }
            }
            return false;
        }

        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while(!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    Objeto objeto = ConstruirObjeto(lineaLeida);
                    listaObjetos.Add(objeto);
                }
                lector.Close();
            }
        }

        private Objeto ConstruirObjeto(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            int lado = int.Parse(campos[0]);
            ColorRelleno color = (ColorRelleno)int.Parse(campos[1]);
            TipodeBorde borde = (TipodeBorde)int.Parse(campos[2]);
            Objeto c = new Objeto(lado, borde, color);
            return c;
        }

        public List<Objeto> GetLista()
        {
            return listaObjetos;
        }

        public void Agregar(Objeto objeto)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(objeto);
            }
        }

        private string ConstruirLinea(Objeto objeto)
        {
            return $"{objeto.GetLado()}|{objeto.TipoDeBorde.GetHashCode()}|{objeto.ColorRelleno.GetHashCode()}";
        }

        public void Borrar(Objeto objetoBorrar)
        {
            using (var lector=new StreamReader(_archivo))
            {
                using (var escritor =new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Objeto objetoLeido = ConstruirObjeto(lineaLeida);
                        if (objetoBorrar.GetLado() != objetoLeido.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaObjetos.Remove(objetoBorrar);
        }

        public void Editar(int ladoAnterior, Objeto ObjetoEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Objeto objeto = ConstruirObjeto(lineaLeida);
                        if (ladoAnterior != objeto.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(ObjetoEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }

        public List<Objeto> Filtrar(int intValor)
        {
            return listaObjetos.Where(c => c.GetLado() >= intValor).ToList();
        }

        public int GetCantidad(int? valorFiltro = null)
        {
            if (valorFiltro != null)
            {
                return listaObjetos.Count(c => c.GetLado() >= valorFiltro);
            }
            return listaObjetos.Count;
        }

        public List<Objeto> OrdenarAsc()
        {
            return listaObjetos.OrderBy(c => c.GetLado()).ToList();
        }

        public List<Objeto> OrdenarDesc()
        {
            return listaObjetos.OrderByDescending(c => c.GetLado()).ToList();
        }
    }
}