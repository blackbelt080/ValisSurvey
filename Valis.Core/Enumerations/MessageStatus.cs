﻿
namespace Valis.Core
{
    /// <summary>
    /// Απαριθμεί τα statuses που μπορεί να βρίσκεται ένα συγκεκριμένο μήνυμα (Message) 
    /// </summary>
    public enum MessageStatus : byte
    {
        /// <summary>
        /// Το μήνυμα μόλις έχει δημιουργηθεί και βρίσκεται στην φάση της παραμετροποίησης
        /// <para>Ο χρήστης μπορεί να διαγράψει το μήνυμα</para>
        /// </summary>
        Draft = 0,
        /// <summary>
        /// το μήνυμα έχει χρονοπρογραμματιστεί για αποστολή
        /// <para>Ο χρήστης μπορεί να ακυρώσει την αποστολή ή και να διαγράψει το μήνυμα</para>
        /// </summary>
        Pending = 1,

        /// <summary>
        /// Το σύστημα προετοιμάζει τους αποδέκτες (MessageRecipients) του μηνύματος
        /// <para>Ο χρήστης δεν μπορεί να επέμβει στην διαδικασία!</para>
        /// </summary>
        Preparing = 2,
        /// <summary>
        /// κάποιο λάθος δημιουργήθηκε κατα την προετοιμασία του μηνύματος
        /// </summary>
        PreparingError = 3,
        /// <summary>
        /// το μήνυμα έχει προετοιμαστεί και περιμένει την εκκίνηση της αποστολής των emails
        /// </summary>
        Prepared = 4,

        /// <summary>
        /// Το σύστημα τώρα στέλνει τα emails στους αποδέκτες του μηνύματος
        /// <para>Ο χρήστης δεν μπορεί να επέμβει στην διαδικασία!</para>
        /// </summary>
        Executing = 5,
        /// <summary>
        /// Το σύστημα δεν μπόρεσε να εκτελέσει τις απαραίτητες εργασίες για την αποστολή του μηνύματος
        /// </summary>
        ExecutingError = 6,
        /// <summary>
        /// To σύστημα έχει εκτελέσει όλα τα απαραίτητα για αυτό το μήνυμα με επιτυχία.
        /// </summary>
        Executed = 7,
        /// <summary>
        /// To σύστημα έχει εκτελέσει όλα τα απαραίτητα για αυτό το μήνυμα με επιτυχία.
        /// </summary>
        ExecutedWithErrors = 8,

        /// <summary>
        /// Ο χρήστης έχει ακυρώσει την αποστολή αυτού του μηνύματος στους αποδέκτες του.
        /// <para>Rescheduling του μηνύματος οδηγεί σε status Pending</para>
        /// </summary>
        Cancel = 9
    }
}