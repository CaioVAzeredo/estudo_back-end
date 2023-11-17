const spdy = require("spdy")
const express = require("express")
const fs = require("fs")

const app = express()

app.use(express.static("build"))

spdy.createServer(
    {
        key: fs.readFileSync("./server.key"),
        cert: fs.readFileSync("./server.crt")
    },
    app
).listen(3002, (err) => {
    if(err){
        throw new Error(err)
    }
    console.log("Listening on port 3002")
})