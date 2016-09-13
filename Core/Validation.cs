using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class Validation
    {
        int EmptyControlsCount = 0;

        #region //Validation

        public bool Validate(Control parent)
        {
            Texbox(parent);
            ComboBox(parent);
            MaskedTexBox(parent);

           
            if (EmptyControlsCount > 0)
            {
                MessageBox.Show("Favor de llenar los campos obligatorios", "Validación", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Validate Texbox
        private void Texbox(Control parent)
        {
            TextBox textbox;
            foreach (Control c in parent.Controls)
            {
                textbox = c as TextBox;
                if (textbox != null)
                {
                    if (textbox.CausesValidation)
                    {
                        if (string.IsNullOrEmpty(textbox.Text))
                        {
                            EmptyControlsCount += 1;
                        }
                    }
                }

                if (c.Controls.Count > 0)
                {
                    Texbox(c);
                }
            }
        }

        //Validate ComboBox
        private void ComboBox(Control parent)
        {
            ComboBox comboBox;
            foreach (Control c in parent.Controls)
            {
                comboBox = c as ComboBox;
                if (comboBox != null)
                {
                    if (comboBox.CausesValidation)
                    {
                        if (comboBox.SelectedIndex == -1)
                        {
                            EmptyControlsCount += 1;
                        }
                    }
                }

                if (c.Controls.Count > 0)
                {
                    ComboBox(c);
                }
            }
        }

        //Validate MaskedTexbox
        private void MaskedTexBox(Control parent)
        {
            MaskedTextBox maskedTextBox;
            foreach (Control c in parent.Controls)
            {
                maskedTextBox = c as MaskedTextBox;
                if (maskedTextBox != null)
                {
                    if (maskedTextBox.CausesValidation)
                    {
                        if (string.IsNullOrEmpty(maskedTextBox.Text))
                        {
                            EmptyControlsCount += 1;
                        }
                    }
                }

                if (c.Controls.Count > 0)
                {
                    MaskedTexBox(c);
                }
            }
        }

        #endregion

        #region //Clear Controls

        //Clear all Controls
        public void Clear(Control parent)
        {
            CLearTexbox(parent);
            ClearComboBox(parent);
            ClearMaskedTexBox(parent);
            ResetDateTimePicker(parent);
        }

        //Clear Texbox
        public static void CLearTexbox(Control parent)
        {
            TextBox textbox;
            foreach (Control c in parent.Controls)
            {
                textbox = c as TextBox;

                if (textbox != null && textbox.Name != "txtSearch")
                {
                    textbox.Clear();
                }

                if (c.Controls.Count > 0)
                {
                    CLearTexbox(c);
                }
            }
        }

        //Clear ComboBox
        public static void ClearComboBox(Control parent)
        {
            ComboBox comboBox;
            foreach (Control c in parent.Controls)
            {
                comboBox = c as ComboBox;

                if (comboBox != null)
                {
                    comboBox.SelectedIndex = -1;
                }

                if (c.Controls.Count > 0)
                {
                    ClearComboBox(c);
                }
            }
        }

        //Clear MaskedTexbox
        private static void ClearMaskedTexBox(Control parent)
        {
            MaskedTextBox maskedTextBox;
            foreach (Control c in parent.Controls)
            {
                maskedTextBox = c as MaskedTextBox;

                if (maskedTextBox != null)
                {
                    maskedTextBox.Clear();
                }

                if (c.Controls.Count > 0)
                {
                    ClearMaskedTexBox(c);
                }
            }
        }

        //Clear MaskedTexbox
        private static void ResetDateTimePicker(Control parent)
        {
            DateTimePicker dateTimePicker;
            foreach (Control c in parent.Controls)
            {
                dateTimePicker = c as DateTimePicker;

                if (dateTimePicker != null)
                {
                    dateTimePicker.ResetText();
                }

                if (c.Controls.Count > 0)
                {
                    ResetDateTimePicker(c);
                }
            }
        }

        #endregion
    }
}
