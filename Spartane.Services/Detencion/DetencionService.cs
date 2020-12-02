using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detencion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detencion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class DetencionService : IDetencionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detencion.Detencion> _DetencionRepository;
        #endregion

        #region Ctor
        public DetencionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detencion.Detencion> DetencionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._DetencionRepository = DetencionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(bool ConRelaciones)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detencion.Detencion> SelAllComplete(bool ConRelaciones)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detencion.Detencion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detencion.Detencion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detencion.DetencionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            DetencionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detencion.Detencion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._DetencionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detencion.Detencion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detencion.Detencion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Detencion.Detencion entity, Spartane.Core.Domain.User.GlobalData DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Detencion.Detencion entity, Spartane.Core.Domain.User.GlobalData DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

