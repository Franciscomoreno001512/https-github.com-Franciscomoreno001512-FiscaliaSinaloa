using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.IPH;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.IPH
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class IPHService : IIPHService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.IPH.IPH> _IPHRepository;
        #endregion

        #region Ctor
        public IPHService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.IPH.IPH> IPHRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._IPHRepository = IPHRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.IPH.IPH> SelAll(bool ConRelaciones)
        {
            return this._IPHRepository.Table.ToList();
        }

        public IList<Core.Domain.IPH.IPH> SelAllComplete(bool ConRelaciones)
        {
            return this._IPHRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.IPH.IPH> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IPHRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.IPH.IPH> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._IPHRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.IPH.IPH> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IPHRepository.Table.ToList();
        }

        public Spartane.Core.Domain.IPH.IPHPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            IPHPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.IPH.IPH> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._IPHRepository.Table.ToList();
        }

        public Spartane.Core.Domain.IPH.IPH GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.IPH.IPH result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData IPHInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.IPH.IPH entity, Spartane.Core.Domain.User.GlobalData IPHInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.IPH.IPH entity, Spartane.Core.Domain.User.GlobalData IPHInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

