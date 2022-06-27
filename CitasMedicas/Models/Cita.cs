﻿namespace CitasMedicas.Models
{
    public class Cita
    {
        public long Id { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string? UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int Hora { get; set; }
        public int PacienteNombre { get; set; }
        public int PacienteCorreo { get; set; }
    }
}
