import React, { Component } from 'react';
import './FullPost.css';
//import axios from 'axios'
import axios from '../../axios'
class FullPost extends Component {

    state={
        post:null
    }
    componentDidUpdate(){
        //this.state.post=this.props.id;
        if(this.props.id)
       if(!this.state.post||(this.state.post&&this.state.post.id!==this.props.id))
axios.get('/posts/'+this.props.id).then(res=>{
    this.setState({post:res.data});
})
    }
    deleteHandler=()=> {
        axios.delete('/posts/'+this.props.id).then(res=>{
            console.log('sucseeded');
        })
    }
    
    render() {
        let post = <p style={{ 'textAlign': 'center' }}>Please select a Post!</p>;
        if(this.props.id)
         post = <p style={{ 'textAlign': 'center' }}>loading .............!</p>;
       if(this.state.post)
        post = (
            <div className="FullPost">
                <h1>{this.state.post.title}</h1>
        <p>{this.state.post.body}</p>
                <div className="Edit">
                    <button className="Delete" onClick={()=>this.deleteHandler()}>Delete</button>
                </div>
            </div>

        );

        return post;
    }
}

export default FullPost;