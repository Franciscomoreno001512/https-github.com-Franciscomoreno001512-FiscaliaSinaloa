using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Motivo_Finalizacion_Turno
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Motivo_Finalizacion_TurnoService : IMotivo_Finalizacion_TurnoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> _Motivo_Finalizacion_TurnoRepository;
        #endregion

        #region Ctor
        public Motivo_Finalizacion_TurnoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> Motivo_Finalizacion_TurnoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Motivo_Finalizacion_TurnoRepository = Motivo_Finalizacion_TurnoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> SelAll(bool ConRelaciones)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> SelAllComplete(bool ConRelaciones)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Motivo_Finalizacion_TurnoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Motivo_Finalizacion_TurnoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

