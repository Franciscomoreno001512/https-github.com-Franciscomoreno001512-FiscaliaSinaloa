using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Especificacion_Detencion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Especificacion_Detencion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Especificacion_DetencionService : IEspecificacion_DetencionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> _Especificacion_DetencionRepository;
        #endregion

        #region Ctor
        public Especificacion_DetencionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> Especificacion_DetencionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Especificacion_DetencionRepository = Especificacion_DetencionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(bool ConRelaciones)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public IList<Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAllComplete(bool ConRelaciones)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especificacion_Detencion.Especificacion_DetencionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Especificacion_DetencionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Especificacion_DetencionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Especificacion_DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion entity, Spartane.Core.Domain.User.GlobalData Especificacion_DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Especificacion_Detencion.Especificacion_Detencion entity, Spartane.Core.Domain.User.GlobalData Especificacion_DetencionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

