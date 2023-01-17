using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabirimler
{
    public interface IDriver { void Drive(); }
    public interface IRecorder { void Record(); }
    public interface IReporter { void Report(); }
    public interface IManager { void Manage(); }

    public class Driver : IDriver, IReporter
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Report()
        {
            throw new NotImplementedException();
        }
    }
    public class Recorder : IRecorder, IReporter
    {
        public void Record()
        {
            throw new NotImplementedException();
        }

        public void Report()
        {
            throw new NotImplementedException();
        }
    }
    public class Manager : IManager, IReporter
    {
        public void Manage()
        {
            throw new NotImplementedException();
        }
        public void Report()
        {
            throw new NotImplementedException();
        }
    }
    public class Reporter : IReporter
    {
        public void Report()
        {
            throw new NotImplementedException();
        }
    }
}
