using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Authentication.Dtos;

// Request
public class OrderRequest
{
    public string Credentials { get; set; }
    public string RequestData { get; set; }
    public string IPAddress { get; set; }
}
