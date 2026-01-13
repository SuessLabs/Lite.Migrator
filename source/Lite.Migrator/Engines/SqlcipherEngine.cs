/* Copyright Xeno Innovations, Inc. 2019
 * Date:    2019-10-6
 * Author:  Damian Suess
 * File:    SqlcipherEngine.cs
 * Description:
 *  Lite.Migrator using the SQLCipher engine
 */

using Lite.Migrator.Versioning;

namespace Lite.Migrator.Engines;

internal class SqlcipherEngine : IEngine
{
  public string LastErrorMessage { get; private set; } = string.Empty;

  public bool MigrateUp()
  {
    throw new System.NotImplementedException();
  }

  public bool MigrateUp(IMigration migration)
  {
    throw new System.NotImplementedException();
  }

  public void VersionInitialize()
  {
    throw new System.NotImplementedException();
  }

  private bool ExecuteQuery()
  {
    return false;
  }
}
