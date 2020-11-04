using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Delegacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Delegacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class DelegacionService : IDelegacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Delegacion.Delegacion> _DelegacionRepository;
        #endregion

        #region Ctor
        public DelegacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Delegacion.Delegacion> DelegacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._DelegacionRepository = DelegacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(bool ConRelaciones)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Delegacion.Delegacion> SelAllComplete(bool ConRelaciones)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delegacion.Delegacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Delegacion.Delegacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delegacion.DelegacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            DelegacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Delegacion.Delegacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._DelegacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Delegacion.Delegacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Delegacion.Delegacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData DelegacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Delegacion.Delegacion entity, Spartane.Core.Domain.User.GlobalData DelegacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Delegacion.Delegacion entity, Spartane.Core.Domain.User.GlobalData DelegacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

