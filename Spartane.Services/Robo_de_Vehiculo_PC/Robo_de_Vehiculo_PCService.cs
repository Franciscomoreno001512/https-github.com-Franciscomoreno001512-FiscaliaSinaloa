using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Robo_de_Vehiculo_PC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Robo_de_Vehiculo_PC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Robo_de_Vehiculo_PCService : IRobo_de_Vehiculo_PCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> _Robo_de_Vehiculo_PCRepository;
        #endregion

        #region Ctor
        public Robo_de_Vehiculo_PCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> Robo_de_Vehiculo_PCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Robo_de_Vehiculo_PCRepository = Robo_de_Vehiculo_PCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> SelAll(bool ConRelaciones)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> SelAllComplete(bool ConRelaciones)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Robo_de_Vehiculo_PCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Robo_de_Vehiculo_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

