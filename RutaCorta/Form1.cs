using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaCorta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[,] grafo = LeerMatriz();
            int nodoInicio = int.Parse(txtNodoInicio.Text);
            int nodoDestino = int.Parse(txtNodoDestino.Text);

            string resultado = Dijkstra(grafo, nodoInicio, nodoDestino);
            lblResultado.Text = resultado;
        }

        private int[,] LeerMatriz()
        {
            int filas = dgvMatriz.RowCount;
            int[,] matriz = new int[filas, filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    matriz[i, j] = int.Parse(dgvMatriz[j, i].Value.ToString());
                }
            }
            return matriz;
        }

        private string Dijkstra(int[,] grafo, int inicio, int destino)
        {
            int n = grafo.GetLength(0);
            int[] dist = new int[n];
            bool[] visitado = new bool[n];
            int[] previo = new int[n];

            for (int i = 0; i < n; i++)
            {
                dist[i] = int.MaxValue;
                previo[i] = -1;
            }
            dist[inicio] = 0;

            for (int i = 0; i < n; i++)
            {
                int u = MinimoDistancia(dist, visitado);
                visitado[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visitado[v] && grafo[u, v] != 0 && dist[u] + grafo[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + grafo[u, v];
                        previo[v] = u;
                    }
                }
            }

            return ConstruirRuta(previo, inicio, destino, dist[destino]);
        }

        private int MinimoDistancia(int[] dist, bool[] visitado)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < dist.Length; v++)
            {
                if (!visitado[v] && dist[v] <= min)
                {
                    min = dist[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        private string ConstruirRuta(int[] previo, int inicio, int destino, int distancia)
        {
            if (distancia == int.MaxValue)
                return "No hay ruta disponible.";

            Stack<int> ruta = new Stack<int>();
            int actual = destino;

            while (actual != -1)
            {
                ruta.Push(actual);
                actual = previo[actual];
            }

            string rutaStr = string.Join(" -> ", ruta);
            return $"Ruta más corta: {rutaStr} \nDistancia: {distancia}";
        }



    }
}
