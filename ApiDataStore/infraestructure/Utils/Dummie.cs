using infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infraestructure.Utils
{
    public class Dummie
    {
        public List<T_InterConnect> ObtenerDatos()
        {
            List<T_InterConnect> datos = new List<T_InterConnect>
            {
                new T_InterConnect
                {
                    CLIENTE = "009036",
                    NOMBRE = "LORENA QUESADA GUEVARA",
                    NIT = "601070597",
                    LIMITE_CREDITO = 350000,
                    TMP = 41,
                    ANT = 19,
                    FACT = 21
                },
                new T_InterConnect
                {
                    CLIENTE = "009037",
                    NOMBRE = "KELIN MORALES LEITON",
                    NIT = "603690764",
                    LIMITE_CREDITO = 250000,
                    TMP = 6,
                    ANT = 16,
                    FACT = 2
                },
                 new T_InterConnect
                {
                    CLIENTE = "009038",
                    NOMBRE = "KARLA VANESSA MELENDEZ CHACON",
                    NIT = "303690367",
                    LIMITE_CREDITO = 0,
                    TMP = 0,
                    ANT = 0,
                    FACT = 0
                }, new T_InterConnect
                {
                    CLIENTE = "009039",
                    NOMBRE = "MARJORIE UMANA ARTAVIA",
                    NIT = "701470803",
                    LIMITE_CREDITO = 200000,
                    TMP = 49,
                    ANT = 10,
                    FACT = 10
                }, new T_InterConnect
                {
                    CLIENTE = "009040",
                    NOMBRE = "JENNY GABRIELA ARAYA JRION",
                    NIT = "701700536",
                    LIMITE_CREDITO = 150000,
                    TMP = 51,
                    ANT = 14,
                    FACT = 3
                }, new T_InterConnect
                {
                    CLIENTE = "009041",
                    NOMBRE = "VIVIAN OCONITRILLO SANCHEZ",
                    NIT = "701000385",
                    LIMITE_CREDITO = 100000,
                    TMP = 71,
                    ANT = 8,
                    FACT = 4
                }, new T_InterConnect
                {
                    CLIENTE = "009042",
                    NOMBRE = "FLORIBETH TORRES DE LA O",
                    NIT = "115520718",
                    LIMITE_CREDITO = 15000,
                    TMP = 14,
                    ANT = 0,
                    FACT =4
                }, new T_InterConnect
                {
                    CLIENTE = "009043",
                    NOMBRE = "ARIELA ESPINOZA MADRIGAL",
                    NIT = "116480685",
                    LIMITE_CREDITO = 0,
                    TMP = 1,
                    ANT = 0,
                    FACT =1
                }, new T_InterConnect
                {
                    CLIENTE = "009044",
                    NOMBRE = "GENESIS CAMPOS ARTAVIA",
                    NIT = "116820818",
                    LIMITE_CREDITO = 0,
                    TMP = 2,
                    ANT = 10,
                    FACT =2
                }, new T_InterConnect
                {
                    CLIENTE = "008947",
                    NOMBRE = "MARIA MAGDALENA UMANA PEREZ",
                    NIT = "501250502",
                    LIMITE_CREDITO = 150000,
                    TMP = 64,
                    ANT = 0,
                    FACT =1
                }

                // ... añadir el resto de los datos de la misma manera
            };

            return datos;
        }
    }
}
