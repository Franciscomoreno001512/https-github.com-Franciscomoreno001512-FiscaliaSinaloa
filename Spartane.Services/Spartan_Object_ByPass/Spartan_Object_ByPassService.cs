using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Spartan_Object_ByPass
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Spartan_Object_ByPassService : ISpartan_Object_ByPassService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> _Spartan_Object_ByPassRepository;
        #endregion

        #region Ctor
        public Spartan_Object_ByPassService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> Spartan_Object_ByPassRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Spartan_Object_ByPassRepository = Spartan_Object_ByPassRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> SelAll(bool ConRelaciones)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> SelAllComplete(bool ConRelaciones)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Spartan_Object_ByPassPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Spartan_Object_ByPassRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

