// JavaScript function to download files from Blazor
window.downloadFile = function(filename, base64Content, contentType) {
    // Convert base64 to blob
    const byteCharacters = atob(base64Content);
    const byteNumbers = new Array(byteCharacters.length);
    for (let i = 0; i < byteCharacters.length; i++) {
        byteNumbers[i] = byteCharacters.charCodeAt(i);
    }
    const byteArray = new Uint8Array(byteNumbers);
    const blob = new Blob([byteArray], { type: contentType });

    // Create download link
    const url = window.URL.createObjectURL(blob);
    const link = document.createElement('a');
    link.href = url;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    window.URL.revokeObjectURL(url);
};

// JavaScript function to set PDF preview in iframe
window.setPdfPreview = function(iframeId, base64Content) {
    try {
        // Convert base64 to blob URL for better browser compatibility
        const byteCharacters = atob(base64Content);
        const byteNumbers = new Array(byteCharacters.length);
        for (let i = 0; i < byteCharacters.length; i++) {
            byteNumbers[i] = byteCharacters.charCodeAt(i);
        }
        const byteArray = new Uint8Array(byteNumbers);
        const blob = new Blob([byteArray], { type: 'application/pdf' });
        const url = URL.createObjectURL(blob);
        
        const iframe = document.getElementById(iframeId);
        if (iframe) {
            // Revoke previous URL if exists
            if (iframe.dataset.blobUrl) {
                URL.revokeObjectURL(iframe.dataset.blobUrl);
            }
            iframe.src = url;
            iframe.dataset.blobUrl = url; // Store URL for cleanup
            return true;
        }
        return false;
    } catch (error) {
        console.error('Error setting PDF preview:', error);
        return false;
    }
};

