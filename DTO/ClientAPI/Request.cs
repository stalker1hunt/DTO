namespace DTO.ClientAPI
{
    internal class Request
    {
        /// <summary>
        /// FunctionName - server side name Method
        /// </summary>
        public string FunctionName { get; internal set; }
        /// <summary>
        /// FunctionParameter - object must be to easy parse in Server
        /// </summary>
        public object FunctionParameter { get; internal set; }
    }
}