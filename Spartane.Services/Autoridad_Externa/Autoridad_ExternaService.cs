using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Autoridad_Externa;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Autoridad_Externa
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Autoridad_ExternaService : IAutoridad_ExternaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> _Autoridad_ExternaRepository;
        #endregion

        #region Ctor
        public Autoridad_ExternaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> Autoridad_ExternaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Autoridad_ExternaRepository = Autoridad_ExternaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(bool ConRelaciones)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public IList<Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAllComplete(bool ConRelaciones)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Autoridad_Externa.Autoridad_ExternaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Autoridad_ExternaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Autoridad_ExternaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Autoridad_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa entity, Spartane.Core.Domain.User.GlobalData Autoridad_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Autoridad_Externa.Autoridad_Externa entity, Spartane.Core.Domain.User.GlobalData Autoridad_ExternaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

