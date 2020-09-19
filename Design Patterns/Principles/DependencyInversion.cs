using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Principles.Interfaces
{
    class DependencyInversion
    {
        // Don't rely on implementation rather on abstraction
        // Incase of C# Interface, Abstract classes provides a level of abstraction

        private readonly IImposter _imposter;

        // We are not depending on the implementation of an imposter rather on the interface 
        public DependencyInversion(IImposter imposter)
        {
            _imposter = imposter;
        }

        // Example method
        public void KillWithImposter(ICrew crew)
        {
            _imposter.Kill(crew);
        }

    }
}
