function downloadFile(fileName, bytesBase64) {
    const link = document.createElement('a');
    link.href = 'data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,' + bytesBase64;
    link.download = fileName;
    link.click();
}

function printData() {
    const printContent = document.getElementById('tableData').innerHTML;
    const win = window.open('', '', 'height=500,width=800');
    win.document.write('<html><head><title>Print Clients</title>');
    win.document.write('</head><body >');
    win.document.write('<h1>Clients List</h1>');
    win.document.write(printContent);
    win.document.write('</body></html>');
    win.document.close();
    win.print();
}