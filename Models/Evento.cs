
using System;
using System.ComponentModel;

namespace EventosApp.Models
{
    public class Evento : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        private DateTime _dataInicio = DateTime.Today;
        public DateTime DataInicio
        {
            get => _dataInicio;
            set
            {
                if (_dataInicio != value)
                {
                    _dataInicio = value;
                    OnPropertyChanged(nameof(DataInicio));
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        private DateTime _dataTermino = DateTime.Today.AddDays(1);
        public DateTime DataTermino
        {
            get => _dataTermino;
            set
            {
                if (_dataTermino != value)
                {
                    _dataTermino = value;
                    OnPropertyChanged(nameof(DataTermino));
                    OnPropertyChanged(nameof(DuracaoEmDias));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        private int _numeroParticipantes;
        public int NumeroParticipantes
        {
            get => _numeroParticipantes;
            set
            {
                if (_numeroParticipantes != value)
                {
                    _numeroParticipantes = value;
                    OnPropertyChanged(nameof(NumeroParticipantes));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        private string _local;
        public string Local
        {
            get => _local;
            set
            {
                if (_local != value)
                {
                    _local = value;
                    OnPropertyChanged(nameof(Local));
                }
            }
        }

        private decimal _custoPorParticipante;
        public decimal CustoPorParticipante
        {
            get => _custoPorParticipante;
            set
            {
                if (_custoPorParticipante != value)
                {
                    _custoPorParticipante = value;
                    OnPropertyChanged(nameof(CustoPorParticipante));
                    OnPropertyChanged(nameof(CustoTotal));
                }
            }
        }

        public int DuracaoEmDias
        {
            get
            {
                TimeSpan diferenca = DataTermino - DataInicio;
                return diferenca.Days;
            }
        }

        public decimal CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
