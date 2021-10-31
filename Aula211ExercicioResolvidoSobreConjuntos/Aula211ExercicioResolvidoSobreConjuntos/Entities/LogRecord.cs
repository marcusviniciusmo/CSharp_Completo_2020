using System;

namespace Aula211ExercicioResolvidoSobreConjuntos.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord otherLogRecord = obj as LogRecord;

            return Username.Equals(otherLogRecord.Username);
        }
    }
}
