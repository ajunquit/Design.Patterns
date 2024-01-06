using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Validators.Handlers;

// Handler interface
public abstract class ValidatorHandler
{
    protected ValidatorHandler successor;

    public void SetSuccessor(ValidatorHandler successor) {  
        this.successor = successor; 
    }

    public abstract bool Validate(string input);
}
