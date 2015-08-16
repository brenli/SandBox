using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    /// <summary>
    /// 1)	Создать свойство string IP, с контролем на корректные значения.
    /// 2)	Создать свойство string FilePath, которое позволит присваивать, только корректный путь, к существующим файлам на диске.
    /// 3)  Больше из области троло:
    ///     a.Создать свойство, которое позволит менять свое значение только 3 раза.
    ///     b.Создать свойство, которое позволяет прочитать себя только 1 раз.
    /// 4)	Создать свойство GetRandomNumber, которое возвращает рандомное число в диапазоне от -77 до 77.  
    /// </summary>
    class Properties
    {
        // 1. IP
        private string ip;
        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
        // 2. FilePath

        // 3. a. X

        // 3. b. Y

        // 4. GetRandomNumber
        public int GetRandomNumber { get; set; }
    }
}
