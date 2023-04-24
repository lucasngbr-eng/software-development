using StructureAttributes.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace StructureAttributes.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<DataSurfaceLoad> SurfaceLoads { get; set; }
        public MainViewModel()
        {
            List<DataSurfaceLoad> SurfaceLoads = new List<DataSurfaceLoad> {
             new DataSurfaceLoad { cm = 0, Material = "Gesso", KgM2Cm = 7.0, Index = 0},
                new DataSurfaceLoad { cm = 0, Material = "Compensado", KgM2Cm = 7.5, Index = 1},
                new DataSurfaceLoad { cm = 0, Material = "Ripado de Madeira", KgM2Cm = 10.0, Index = 2},
                new DataSurfaceLoad { cm = 0, Material = "Placa Cimentícia", KgM2Cm = 17.0, Index = 3},
                new DataSurfaceLoad { cm = 0, Material = "Painel Wall", KgM2Cm = 7.0, Index = 4},
                new DataSurfaceLoad { cm = 0, Material = "Entarugamento Médio DE", KgM2Cm = 1.25, Index = 5 },
                new DataSurfaceLoad { cm = 0, Material = "Lã de Rocha", KgM2Cm = 2.5, Index = 6 },
                new DataSurfaceLoad { cm = 0, Material = "Isopor", KgM2Cm = 0.1, Index = 7},
                new DataSurfaceLoad { cm = 0, Material = "OSB", KgM2Cm = 7.0, Index = 8},
                new DataSurfaceLoad { cm = 0, Material = "Manta Acústica EPS", KgM2Cm = 30.0, Index = 9},
                new DataSurfaceLoad { cm = 0, Material = "Manta Impermeabilizante EVA/TPO", KgM2Cm = 5.0, Index = 10},
                new DataSurfaceLoad { cm = 0, Material = "Cinasita", KgM2Cm = 4.5, Index = 11},
                new DataSurfaceLoad { cm = 0, Material = "Manta Geodrenante + Substrato Skygarden", KgM2Cm = 10.0, Index = 12},
                new DataSurfaceLoad { cm = 0, Material = "Deck de Madeira", KgM2Cm = 20.0, Index = 13},
                new DataSurfaceLoad { cm = 0, Material = "Policarbonato", KgM2Cm = 12.0, Index = 14},
                new DataSurfaceLoad { cm = 0, Material = "Vidro", KgM2Cm = 24.0, Index = 15},
                new DataSurfaceLoad { cm = 0, Material = "Taubilha", KgM2Cm = 10.0, Index = 16},
                new DataSurfaceLoad { cm = 0, Material = "Telha Termoacústica", KgM2Cm = 20.0, Index = 17},
                new DataSurfaceLoad { cm = 0, Material = "Telha Aço Singela", KgM2Cm = 14.0, Index = 18},
                new DataSurfaceLoad { cm = 0, Material = "Equipamento Solar", KgM2Cm = 15.0, Index = 19},
                new DataSurfaceLoad { cm = 0, Material = "Telha Cerâmica", KgM2Cm = 70.0, Index = 20},
                new DataSurfaceLoad { cm = 0, Material = "Telha Shingle", KgM2Cm = 18.0, Index = 21},
                new DataSurfaceLoad { cm = 0, Material = "Manta Acústica", KgM2Cm = 3.0, Index = 22},
                new DataSurfaceLoad { cm = 0, Material = "Manta Asfáltica", KgM2Cm = 20.0, Index = 23},
                new DataSurfaceLoad { cm = 0, Material = "Concreto Leve (1400kg/m³)", KgM2Cm = 14.0, Index = 24},
                new DataSurfaceLoad { cm = 0, Material = "Concreto", KgM2Cm = 25.0, Index = 25},
                new DataSurfaceLoad { cm = 0, Material = "Argamassa", KgM2Cm = 21.0, Index = 26},
                new DataSurfaceLoad { cm = 0, Material = "Assoalho de Madeira", KgM2Cm = 10.0, Index = 27},
                new DataSurfaceLoad { cm = 0, Material = "Piso Cerâmico", KgM2Cm = 18.0, Index = 28},
                new DataSurfaceLoad { cm = 0, Material = "Placa Concresteel", KgM2Cm = 24.0, Index = 29 },
                new DataSurfaceLoad { cm = 0, Material = "Paredes com PP<35kg/m²", KgM2Cm = 50.0, Index = 30},
                new DataSurfaceLoad { cm = 0, Material = "Paredes com PP<65kg/m²", KgM2Cm = 75.0, Index = 31},
                new DataSurfaceLoad { cm = 0, Material = "Paredes com PP<100kg/m²", KgM2Cm = 100.0, Index = 32}
            };

            
        }
           
    }
}
