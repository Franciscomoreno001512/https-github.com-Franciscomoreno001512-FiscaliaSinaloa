using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Expediente_para_Reuniones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_Expediente_para_ReunionesService : IEstatus_de_Expediente_para_ReunionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> _Estatus_de_Expediente_para_ReunionesRepository;
        #endregion

        #region Ctor
        public Estatus_de_Expediente_para_ReunionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> Estatus_de_Expediente_para_ReunionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_Expediente_para_ReunionesRepository = Estatus_de_Expediente_para_ReunionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_ReunionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_Expediente_para_ReunionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_Expediente_para_ReunionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_para_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

