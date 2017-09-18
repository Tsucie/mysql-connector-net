﻿// Copyright © 2017 Oracle and/or its affiliates. All rights reserved.
//
// MySQL Connector/NET is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using MySql.Data.EntityFrameworkCore.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySQL.Data.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Metadata.Internal;

namespace MySql.Data.EntityFrameworkCore.Metadata.Conventions
{
  internal class MySqlEntityCollationAttributeConvention : EntityTypeAttributeConvention<MySqlCollationAttribute>
  {
    public override InternalEntityTypeBuilder Apply([NotNull] InternalEntityTypeBuilder entityTypeBuilder, [NotNull] MySqlCollationAttribute attribute)
    {
      entityTypeBuilder.Metadata.SetAnnotation(MySQLFullAnnotationNames.Instance.Collation, attribute.Collation, ConfigurationSource.DataAnnotation);
      return entityTypeBuilder;
    }
  }
}
