using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore_Models.Models;

public record Car
{
    public int Id { get; set; }

    public string Brand { get; set; }

    public string Model { get; set; }

    public DateTime ReleaseDate { get; set; }

    public int BuyerId { get; set; }

    
}
