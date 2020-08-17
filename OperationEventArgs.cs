using System;

namespace ATM_Sim
{
    /// <summary>
    /// Класс, содержащий данные событий, и предоставляющий  свойства, необходимые для хранения данных события. 
    /// </summary>
    class OperationEventArgs : EventArgs
    {
        /// <value>Свойство, хранящее сообщение о том какого рода операция произошла</value>
        public string Message { get; set; }
        /// <value>Свойство, хранящее дату и время операции</value>
        public DateTime TimeStartOperation { get; set; }
    }
}
