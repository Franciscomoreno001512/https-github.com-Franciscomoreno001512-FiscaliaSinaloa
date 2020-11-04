using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Reuniones_de_Mediacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Reuniones_de_MediacionService : IDetalle_de_Reuniones_de_MediacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> _Detalle_de_Reuniones_de_MediacionRepository;
        #endregion

        #region Ctor
        public Detalle_de_Reuniones_de_MediacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> Detalle_de_Reuniones_de_MediacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Reuniones_de_MediacionRepository = Detalle_de_Reuniones_de_MediacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_MediacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Reuniones_de_MediacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Reuniones_de_MediacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Reuniones_de_MediacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Reuniones_de_MediacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Reuniones_de_Mediacion.Detalle_de_Reuniones_de_Mediacion entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Reuniones_de_MediacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

