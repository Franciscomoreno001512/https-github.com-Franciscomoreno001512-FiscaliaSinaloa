using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Condiciones_Proceso_Penal
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Condiciones_Proceso_PenalService : IDetalle_Condiciones_Proceso_PenalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> _Detalle_Condiciones_Proceso_PenalRepository;
        #endregion

        #region Ctor
        public Detalle_Condiciones_Proceso_PenalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> Detalle_Condiciones_Proceso_PenalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Condiciones_Proceso_PenalRepository = Detalle_Condiciones_Proceso_PenalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_PenalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Condiciones_Proceso_PenalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Condiciones_Proceso_PenalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

