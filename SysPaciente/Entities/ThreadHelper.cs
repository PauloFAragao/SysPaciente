using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace SysPaciente.Entities
{
    public static class ThreadHelper
    {
        public static void SetPropertyValue(Control control, string property, object value)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => SetPropertyValue(control, property, value)));
            }
            else
            {
                try
                {
                    PropertyInfo prop = control.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);

                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(control, value);
                    }
                }
                catch (TargetInvocationException ex)
                {
                    Console.WriteLine(ex.InnerException?.Message);
                }
            }
        }

        //-------------------------- métodos para manipular DataGridView
        public static void SetColumnVisibility(DataGridView dataGridView, int columnIndex, bool visible)
        {
            try
            {
                if (!dataGridView.IsDisposed)
                {
                    if (dataGridView.InvokeRequired)
                    {
                        // Chama o método usando o delegate
                        dataGridView.Invoke(new Action(() => SetColumnVisibility(dataGridView, columnIndex, visible)));
                    }
                    else
                    {
                        // Define a visibilidade da coluna
                        dataGridView.Columns[columnIndex].Visible = visible;
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                Debug.WriteLine($"O controle foi descartado: {ex.Message}");
            }
        }

        public static void SetColumnHeaderText(DataGridView dataGridView, int columnIndex, string headerText)
        {
            try
            {
                if (!dataGridView.IsDisposed)
                {
                    if (dataGridView.InvokeRequired)
                    {
                        // Chama o método usando o delegate
                        dataGridView.Invoke(new Action(() => SetColumnHeaderText(dataGridView, columnIndex, headerText)));
                    }
                    else
                    {
                        // Define o texto do cabeçalho da coluna
                        dataGridView.Columns[columnIndex].HeaderText = headerText;
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                Debug.WriteLine($"O controle foi descartado: {ex.Message}");
            }
        }

        public static void SetColumnAutoSizeMode(DataGridView dataGridView, int columnIndex, DataGridViewAutoSizeColumnMode autoSizeMode)
        {
            try
            {
                if (!dataGridView.IsDisposed)
                {
                    if (dataGridView.InvokeRequired)
                    {
                        // Chama o método usando o delegate
                        dataGridView.Invoke(new Action(() => SetColumnAutoSizeMode(dataGridView, columnIndex, autoSizeMode)));
                    }
                    else
                    {
                        // Define o modo de redimensionamento automático da coluna
                        dataGridView.Columns[columnIndex].AutoSizeMode = autoSizeMode;
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                Debug.WriteLine($"O controle foi descartado: {ex.Message}");
            }
        }

        public static void SelectFirstRow(DataGridView dataGridView)
        {
            try
            {
                if (!dataGridView.IsDisposed)
                {
                    if (dataGridView.InvokeRequired)
                    {
                        // Chama o método no thread da interface do usuário
                        dataGridView.BeginInvoke(new Action(() => SelectFirstRow(dataGridView)));
                    }
                    else
                    {
                        // Verifica se há pelo menos uma linha
                        if (dataGridView.Rows.Count > 0)
                            dataGridView.Rows[0].Selected = true; // Seleciona a linha 0
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                Debug.WriteLine($"O controle foi descartado: {ex.Message}");
            }
        }
    }
}
