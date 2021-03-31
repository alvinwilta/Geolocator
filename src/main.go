package main

import (
	"bufio"
	"fmt"
	//"io/ioutil"
	"log"
	"os"
	//"strings"
)

type Simpul struct {
	Lat, Long float64
}

var Kamus map[Simpul]int
var Node int
var DataNode [][]string


/*func input(filename string) [][]string {
	var hasil [...][...]string
	
}*/

func main(){
	file, err := os.Open("../test/graph.txt")
    if err != nil {
        log.Fatal(err)
    }
    defer file.Close()

    scanner := bufio.NewScanner(file)
    for scanner.Scan() {
		//s := strings.Split(scanner.Text(), ",") clean komma
		//fmt.Println(s)
        fmt.Println(scanner.Text())
    }

    if err := scanner.Err(); err != nil {
        log.Fatal(err)
    }
}
