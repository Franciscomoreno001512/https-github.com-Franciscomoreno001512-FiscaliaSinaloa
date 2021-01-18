using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_telefono;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_telefono
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_telefonoService : IDetalle_de_telefonoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> _Detalle_de_telefonoRepository;
        #endregion

        #region Ctor
        public Detalle_de_telefonoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> Detalle_de_telefonoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_telefonoRepository = Detalle_de_telefonoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_telefono.Detalle_de_telefono> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefonoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_telefonoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_telefonoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_telefonoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono entity, Spartane.Core.Domain.User.GlobalData Detalle_de_telefonoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_telefono.Detalle_de_telefono entity, Spartane.Core.Domain.User.GlobalData Detalle_de_telefonoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

