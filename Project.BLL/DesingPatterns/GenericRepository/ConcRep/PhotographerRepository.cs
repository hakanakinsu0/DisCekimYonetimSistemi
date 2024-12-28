using Project.BLL.DesingPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesingPatterns.GenericRepository.ConcRep
{
    public class PhotographerRepository : BaseRepository<Photographer>
    {
        // Telefon numarasının var olup olmadığını kontrol eden metot
        public bool IsPhoneNumberExists(string phoneNumber)
        {
            return Any(x => x.PhoneNumber == phoneNumber);
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 11 && phoneNumber.All(char.IsDigit);
        }
    }
}
