//
//  Problem96.cpp
//  ProjectEuler
//
//  Created by Andy Meyers on 1/28/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#include "Problem96.h"
#include <algorithm>

using namespace std;


typedef list<SodukuGame>::iterator iter;
typedef vector<ValidMoves>::iterator moves_iter;


bool sort_valid_moves(const ValidMoves& vm1, const ValidMoves& vm2){
    return vm1.moves.size() < vm2.moves.size();
}

bool SodukuGame::is_solved(){
    
    if (!is_valid()){
        return false;
    }
    
    // check rows to make sure there is one of each
    for(int y = 0; y < 9; y++){
        int num_count[10];
        std::fill_n(num_count, 10, 0);
        
        for(int x = 0; x < 9; x++){
            num_count[rows[y][x] - 1] += 1;
        }
        
        for (int i = 0; i < 9; i++) {
            if(num_count[i] > 1){
                cout << "Row count off. y => " << y << endl;
                this -> _is_valid = false;
                return false;
            }
        }
        
    }
    
    // check columns to make sure there is one of each
    for (int x = 0; x < 9; x++){
        int num_count[10];
        std::fill_n(num_count, 10, 0);
        for(int y = 0; y < 9; y++){
            num_count[rows[y][x] - 1] += 1;
        }
        
        for (int i = 0; i < 9; i++) {
            if(num_count[i] != 1){
                cout << "Col count off. x => " << x << endl;
                this -> _is_valid = false;
                return false;
            }
        }
        
    }
    
    // check to make sure there are 0s
    for(int y = 0; y < 9; y++){
        
        for(int x = 0; x < 9; x++){
            if (rows[y][x] == 0){
                return false;
            }
        }
        
    }
    

    return true;
}


void SodukuGame::solve_puzzle(){

    
    vector<ValidMoves> moves = get_valid_moves();

    // while there are moves to make
    while(!moves.empty()){
        // sort moves
        sort(moves.begin(), moves.end(), &sort_valid_moves);
        
        
        // guess and check
        if (moves[0].moves.size() > 1){
        
            // for each possible combo try them out with the lowest guesses first
            ValidMoves guessMove = moves[0];
            for (int i = 0; i < guessMove.moves.size(); i++){
                SodukuGame copy = *this;
                copy.make_move(guessMove.moves[i], guessMove.x, guessMove.y);
                cout << "-------originalprint-------" <<endl;
                this -> print();
                cout << "-------copyprint-------" <<endl;
                copy.print();
                copy.solve_puzzle();
                // if solved then copy the rows
                if ( copy.is_solved()){
                    (*this).rows = copy.rows;
                    return;
                }
                else{
                    cout << "Failed Solution: " << endl;
                    copy.print();
                    
                }
                
            }
            // this puzzle is borked.
            cout << "WTF YO!" << endl;
            this -> print();
            return;
        }
        else if (moves[0].moves.size() == 1){
            
            // for each single move then make it
            int i = 0;
            while(moves.size() > i && moves[i].moves.size() == 1){
                
//                cout << "x: " << moves[i].x << ", y: " << moves[i].y << ", val: " << moves[i].moves[0] << endl;
                make_move(moves[i].moves[0], moves[i].x, moves[i].y);
                
                i++;
            }
            
            cout << i << "-> single moves" << endl;
            print();
        }
        
        if (!is_valid()){
            cout << "something else wrong " << endl;
            return;
        }
        
        
        moves = get_valid_moves();
    }
    
    
    cout << "No more moves: " << endl;
    
    print();
    
}
int SodukuGame::get_solution(){
    return rows[0][0] * 100 + rows[0][1] * 10 + rows[0][2];
}
void SodukuGame::print(){
    
    for (int y = 0; y < 9; y++){
        string line;
        for (int x = 0; x < 9; x++){
            line = line + std::to_string(rows[y][x]) + " ";
        }
        
        cout << line << endl;
    }
    
    cout << "- - - - - - - - - -" << endl;

}

vector<ValidMoves> SodukuGame::get_valid_moves(){
    vector<ValidMoves> board_moves;
    
    for(int y = 0; y < 9; y++){
        vector<vector<int>> current_row_moves;
        for(int x = 0; x < 9; x++){
            if (rows[y][x] != 0){
//                valid_moves.moves.push_back(rows[y][x]);
            }
            else{
                ValidMoves valid_moves(x,y);
       
                for(int i = 1; i < 10; i++){
                    if (is_move_valid(i, x, y, rows)){
                        valid_moves.moves.push_back(i);
                    }
                }
                
                if (valid_moves.moves.size() == 0){
                    _is_valid = false;
                }
                
                board_moves.push_back(valid_moves);
            }
            
        }
    }
    
    return board_moves;
}

bool SodukuGame::is_move_valid(int val, int x, int y, const std::vector<std::vector<int>>& board){

    for (int i = 0; i < x; i++){
        // check row to the left
        if (board[y][i] == val){
            return false;
        }
    }
    for(int i = x + 1; i < 9; i++){
        // check row to the right
        if (board[y][i] == val){
            return false;
        }
    }
    
    for (int i = 0; i < y; i++){
        // check column above
        if (board[i][x] == val){
            return false;
        }
    }
    for(int i = y + 1; i < 9; i++){
        // check column below
        if (board[i][x] == val){
            return false;
        }
    }
    
    
    // check remaining 4 in cube
    int x_mod = x % 3;
    int y_mod = y % 3;
    vector<int> x_cols;
    vector<int> y_cols;
    
    if (x_mod == 0){
        x_cols.push_back(x + 1);
        x_cols.push_back(x + 2);
    }
    else if(x_mod == 1){
        x_cols.push_back(x + 1);
        x_cols.push_back(x - 1);
    }
    else {
        x_cols.push_back(x - 2);
        x_cols.push_back(x - 1);
    }
    
    if (y_mod == 0){
        y_cols.push_back(y + 1);
        y_cols.push_back(y + 2);
    }
    else if(y_mod == 1){
        y_cols.push_back(y + 1);
        y_cols.push_back(y - 1);
    }
    else {
        y_cols.push_back(y - 2);
        y_cols.push_back(y - 1);
    }
    
    for (int y1 = 0; y1 < 2; y1++){
        int yi = y_cols[y1];
        for (int x1 = 0; x1 < 2; x1++){
            int xi = x_cols[x1];
            
            if (board[yi][xi] == val){
                return false;
            }
        }
    }
    
    return true;
}

list<SodukuGame> Problem96::read_file(string filename){
    list<SodukuGame> puzzles;
    string line;
    ifstream myfile(filename);
    int count = 0;
    vector<vector<int>> rows;
    while (getline( myfile, line )){
        
        if (count > 0){
            vector<int> new_row;
            for (int i = 0; i < 9; i++){
                new_row.push_back(line[i] - '0');
            }
            rows.push_back(new_row);
        }
        
        count++;
        
        if (count == 10){
            count = 0;
            puzzles.push_back(SodukuGame(rows));
            rows.clear();
        }
    }
    
    return puzzles;
}

void Problem96::generate_answer(){
    static string FILE_NAME = "/Users/andymeyers/Documents/ProjectEuler/ProjectEuler/ProjectEuler/soduku.txt";
        
    // parse file into games
    list<SodukuGame> games = read_file(FILE_NAME);
    
    iter begin = games.begin();
    int i = 0,
    total = 0;
    
    // for each game solve
    while(begin != games.end()){
        
        SodukuGame game = *begin;
        
        game.solve_puzzle();
        
        if (game.is_valid()){
            total += game.get_solution();
            cout << "Game # " << i << " solution." << endl;
            game.print();
        }
        else {
            game.print();
            cout << "logic is wrong.  Puzzle #:" << i <<   endl;
        }
//        begin = games.end();
        begin++;
        i++;
    }
    
    cout << total;
    

}
