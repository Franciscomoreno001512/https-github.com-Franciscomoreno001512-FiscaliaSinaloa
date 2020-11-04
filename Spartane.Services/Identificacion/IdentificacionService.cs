using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Identificacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Identificacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class IdentificacionService : IIdentificacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Identificacion.Identificacion> _IdentificacionRepository;
        #endregion

        #region Ctor
        public IdentificacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Identificacion.Identificacion> IdentificacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._IdentificacionRepository = IdentificacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Identificacion.Identificacion> SelAll(bool ConRelaciones)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Identificacion.Identificacion> SelAllComplete(bool ConRelaciones)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Identificacion.Identificacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Identificacion.Identificacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Identificacion.Identificacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Identificacion.IdentificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            IdentificacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Identificacion.Identificacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._IdentificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Identificacion.Identificacion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Identificacion.Identificacion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData IdentificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Identificacion.Identificacion entity, Spartane.Core.Domain.User.GlobalData IdentificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Identificacion.Identificacion entity, Spartane.Core.Domain.User.GlobalData IdentificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

